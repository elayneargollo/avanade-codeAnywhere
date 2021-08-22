using catalogo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo.Repository
{
    public interface IJogoRepository
    {
        Task<List<Jogo>> GetAll(int pagina, int quantidade);
        Task<List<Jogo>> Get(string nome, string produtora);
        Task<Jogo> GetById(long jogoId);
        Task<Jogo> Add(Jogo jogo);
        Task Update(Jogo jogo);
        void Delete(Jogo jogo);
        void Dispose();
    }
}
