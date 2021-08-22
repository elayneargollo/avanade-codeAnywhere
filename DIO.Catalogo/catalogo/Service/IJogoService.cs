using catalogo.Entity;
using catalogo.InputModel;
using catalogo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo.Interface
{
    public interface IJogoService : IDisposable
    {
        Task<List<Jogo>> GetAll(int pagina, int quantidade);
        Task<Jogo> GetById(long jogoId);
        Task<Jogo> Add(Jogo jogo);
        Task Update(long jogoId, Jogo jogo);
        Task EditParcial(long jogoId, double preco);
        Task Delete(long jogoId); 
    }
}
