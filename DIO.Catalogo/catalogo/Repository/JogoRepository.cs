using catalogo.Entity;
using catalogo.Repository;
using catalogo.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploApiCatalogoJogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly JogoContext _context;

        public JogoRepository(JogoContext context)
        {
            _context = context;
        }

        public Task<Jogo> Add(Jogo jogo)
        {
            Jogo novoJogo = _context.Jogo.Add(jogo).Entity;
            _context.SaveChanges();

            return Task.FromResult(novoJogo);
        }

        public void Delete(Jogo jogo)
        {
            _context.Jogo.Remove(jogo);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Task<List<Jogo>> Get(string nome, string produtora)
        {
            List<Jogo> jogos = _context.Jogo.Where(p => p.Nome == nome && p.Produtora == produtora).ToList();

            return Task.FromResult(jogos);
        }

        public Task<List<Jogo>> GetAll(int pagina, int quantidade)
        {
            List<Jogo> jogos = new List<Jogo>();
            jogos = _context.Jogo.ToList();

            return Task.FromResult(jogos);
        }

        public Task<Jogo> GetById(long jogoId)
        {
            Jogo jogo = _context.Jogo.Where(p => p.Id == jogoId).FirstOrDefault();
            return Task.FromResult(jogo);
        }

        public Task Update(Jogo jogo)
        {
            _context.Jogo.Update(jogo);
            _context.SaveChanges();

            return Task.FromResult(jogo);
        }
    }
}
