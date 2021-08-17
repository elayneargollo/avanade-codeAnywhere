using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = string.Empty;

            retorno = string.Concat(retorno, "Gênero: " + this.Genero + Environment.NewLine);
            retorno = string.Concat(retorno, "Título: " + this.Titulo + Environment.NewLine);
            retorno = string.Concat(retorno, "Descrição: " + this.Descricao + Environment.NewLine);
            retorno = string.Concat(retorno, "Ano de Início: " + this.Ano);

            return retorno;
        }

        public string obterTitulo()
        {
            return this.Titulo;
        }

        internal int obterId()
        {
            return this.Id;
        }

        public void alterarId(int id)
        {
            this.Id = id;
        }

        public void excluir()
        {
            this.Excluido = true;
        }
    }
}