using System.Collections.Generic;

namespace DIO.Series
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSeries = new List<Serie>();

        public void Delet(int id)
        {
            var existItem = listSeries.Exists(s => s.obterId() == id);
            if(existItem) listSeries[id].excluir(); 
        }
        
        public Serie GetById(int id)
        {
            var existItem = listSeries.Exists(s => s.obterId() == id);
            if(existItem) return listSeries[id];

            return null;        
        }

        public void Insert(Serie entity)
        {
            if(entity != null) listSeries.Add(entity);
        }

        public List<Serie> List()
        {
            return listSeries;
        }

        public int NextId()
        {
            return listSeries.Count;
        }

        public void Update(int id, Serie entity)
        {
            var existItem = listSeries.Exists(s => s.obterId() == id);
            if(entity != null && existItem) listSeries[id] = entity;
        }
    }
}