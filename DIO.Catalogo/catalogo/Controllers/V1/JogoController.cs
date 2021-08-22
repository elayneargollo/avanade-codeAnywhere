using AutoMapper;
using catalogo.Entity;
using catalogo.InputModel;
using catalogo.Interface;
using catalogo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IJogoService _jogoService;
        private IMapper _mapper;

        public JogoController(IJogoService jogoService, IMapper mapper)
        {
            _jogoService = jogoService;
            _mapper = mapper;
        }

        /// <summary>
        /// Buscar todos os jogos de forma paginada
        /// </summary>
        /// <remarks>
        /// Não é possível retornar os jogos sem paginação
        /// </remarks>
        /// <param name="pagina">Indica qual página está sendo consultada. Mínimo 1</param>
        /// <param name="quantidade">Indica a quantidade de reistros por página. Mínimo 1 e máximo 50</param>
        /// <response code="200">Retorna a lista de jogos</response>
        /// <response code="204">Caso não haja jogos</response>   
        [HttpGet]
        public async Task<ActionResult<List<JogoViewModel>>> GetAll([FromQuery, Range(1, int.MaxValue)] int pagina=1, [FromQuery, Range(1,50)] int quantidade = 5)
        {
            List<Jogo> jogos = await _jogoService.GetAll(pagina, quantidade);

            if (!jogos.Any()) return NoContent();

            List<JogoViewModel> jogoViewModel = jogos.Select(jogo => _mapper.Map<JogoViewModel>(jogo)).ToList();
            return Ok(jogoViewModel);
        }

        /// <summary>
        /// Buscar um jogo pelo seu Id
        /// </summary>
        /// <param name="idJogo">Id do jogo buscado</param>
        /// <response code="200">Retorna o jogo filtrado</response>
        /// <response code="204">Caso não haja jogo com este id</response>   
        [HttpGet("{jogoId:long}")]
        public async Task<ActionResult<JogoViewModel>> GetById(long jogoId)
        {
            Jogo jogo = await _jogoService.GetById(jogoId);

            if (jogo == null) return NoContent();

            JogoViewModel jogoViewModel = _mapper.Map<JogoViewModel>(jogo);
            return Ok(jogoViewModel);
        }

        /// <summary>
        /// Inserir um jogo no catálogo
        /// </summary>
        /// <param name="jogoInputModel">Dados do jogo a ser inserido</param>
        /// <response code="200">Cao o jogo seja inserido com sucesso</response>
        /// <response code="422">Caso já exista um jogo com mesmo nome para a mesma produtora</response>   
        [HttpPost]
        public async Task<ActionResult<JogoViewModel>> Add(JogoInputModel jogo)
        {
            Jogo novoJogo = await _jogoService.Add(_mapper.Map<Jogo>(jogo));

            if (novoJogo == null) return NotFound();

            JogoViewModel jogoViewModel = _mapper.Map<JogoViewModel>(novoJogo);
            return Ok(jogoViewModel);
        }

        /// <summary>
        /// Atualizar um jogo no catálogo
        /// </summary>
        /// /// <param name="idJogo">Id do jogo a ser atualizado</param>
        /// <param name="jogoInputModel">Novos dados para atualizar o jogo indicado</param>
        /// <response code="200">Cao o jogo seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um jogo com este Id</response>   
        [HttpPut("{jogoId:long}")]
        public async Task<ActionResult> Update(long jogoId, JogoInputModel jogo)
        {
            if (jogo == null) return NotFound();

            Jogo jogoRequest = _mapper.Map<Jogo>(jogo);
            await _jogoService.Update(jogoId, jogoRequest);

            return Ok();
        }

        /// <summary>
        /// Atualizar o preço de um jogo
        /// </summary>
        /// <param name="idJogo">Id do jogo a ser atualizado</param>
        /// <param name="preco">Novo preço do jogo</param>
        /// <response code="200">Cao o preço seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um jogo com este Id</response>   
        [HttpPatch]
        public async Task<ActionResult> Path(double preco, long jogoId)
        {
            await _jogoService.EditParcial(jogoId, preco);
            return Ok();
        }

        /// <summary>
        /// Excluir um jogo
        /// </summary>
        /// /// <param name="idJogo">Id do jogo a ser excluído</param>
        /// <response code="200">Cao o preço seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um jogo com este Id</response>   
        [HttpDelete("{jogoId:long}")]
        public async Task<ActionResult> Delete(long jogoId)
        {
            await _jogoService.Delete(jogoId);
            return Ok();
        }

    }
}
