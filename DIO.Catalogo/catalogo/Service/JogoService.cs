using catalogo.Entity;
using catalogo.Exceptions;
using catalogo.Interface;
using catalogo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo.Service
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _jogoRepository;

        public JogoService(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }

        public async Task<List<Jogo>> GetAll(int pagina, int quantidade)
        {
            return await _jogoRepository.GetAll(pagina, quantidade);
        }

        Task<Jogo> IJogoService.GetById(long jogoId)
        {
            try
            {
                var jogo = _jogoRepository.GetById(jogoId);

                if (jogo == null) throw new Exception("Jogo não encontrado");

                return jogo;
            }
            catch
            {
                throw new Exception("Ocorreu um erro");
            }
        }

        public async Task<Jogo> Add(Jogo jogo)
        {
            try
            {
                List<Jogo> jogoEncontrado = await _jogoRepository.Get(jogo.Nome, jogo.Produtora);

                if (jogoEncontrado.Any()) throw new JogoJaCadastradoException();
                
                return await _jogoRepository.Add(jogo);
            }
            catch
            {
                throw new Exception("Ocorreu um erro ao inserir um jogo");
            }
        }

        public Task Delete(long jogoId)
        {
            try
            {
                Jogo jogo = _jogoRepository.GetById(jogoId).Result;

                if (jogo == null) throw new JogoNaoCadastradoException();

                return Task.FromResult("Jogo deletado com sucesso");
            }
            catch
            {
                throw new Exception("Jogo não existe");
            }
        }

        public void Dispose()
        {
            _jogoRepository.Dispose();
        }

        public Task EditParcial(long jogoId, double preco)
        {
            try
            {
                Jogo jogo = _jogoRepository.GetById(jogoId).Result;

                if (jogo == null) throw new JogoNaoCadastradoException();

                jogo.Preco = preco;

                return Task.FromResult(_jogoRepository.Update(jogo));
            }
            catch
            {
                throw new Exception("Ocorreu um erro ao atualizar o preco do jogo");
            }

        }

        public Task Update(long jogoId, Jogo jogo)
        {
            try
            {
                Jogo jogoEncontrado = _jogoRepository.GetById(jogoId).Result;

                if (jogoEncontrado == null) throw new JogoNaoCadastradoException();
                return _jogoRepository.Update(jogo);
            }
            catch
            { 
                throw new Exception(String.Format("Ocorreu um erro ao atualizar o jogo{0}", jogo.Nome));
            }
        }

    }
}
