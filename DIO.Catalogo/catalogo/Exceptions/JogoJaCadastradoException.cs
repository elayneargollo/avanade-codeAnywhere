using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException() : base("Este jogo está cadastrado") { }
    }
}
