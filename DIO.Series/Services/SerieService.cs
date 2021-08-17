using System;

namespace DIO.Series
{
    public static class SerieService
    {
        static SerieRepository repository = new SerieRepository();

        public static void ListSerie()
        {
            var lista = repository.List();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            Console.WriteLine("===================================");
            Console.WriteLine("Lista de Séries Cadastradas");

            foreach(var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.obterId(), serie.obterTitulo());
            }
        }

        public static void InsertSerie()
        {
            var novaSerie = FillObject();
            novaSerie.alterarId(repository.NextId());

            repository.Insert(novaSerie);
            Console.Clear();
        }

        public static void UpdateSerie()
        {
            Console.WriteLine("Informe o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var serie = repository.GetById(id);

            if(serie == null) 
            {
                Console.WriteLine("Série não encontrada ");
                return;
            }

            var updateSerie = FillObject();
            updateSerie.alterarId(id);

            repository.Update(id, updateSerie);
        }

        public static void DeletSerie()
        {
            Console.WriteLine("Informe o id da série: ");
            int id = int.Parse(Console.ReadLine());

            repository.Delet(id);
        }

        public static void GetById()
        {
            Console.WriteLine("Informe o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var serie = repository.GetById(id);

            if(serie == null) Console.WriteLine("Série não encontrada ");
            else Console.WriteLine(serie);
        }

        public static Serie FillObject()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Lista de Gênero");
            Console.WriteLine("===================================");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}: - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Informe o gênero entre as opções acima: ");
            int enumGenero = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Informe o título da Série: ");
            string titulo = Console.ReadLine();

            Console.Write("Informe o ano de início da série: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Informe a descrição da Série: ");
            string descricao = Console.ReadLine();

            return new Serie(id: 0, genero: (Genero)enumGenero, titulo: titulo, ano: ano, descricao: descricao);
        }

    }
}