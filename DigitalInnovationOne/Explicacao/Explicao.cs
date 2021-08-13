using System;

namespace DigitalInnovationOne
{
    class Explicacao
    {

        public void Conceito()
        {
            Console.WriteLine("\n=> O que é C# ?");

            Console.WriteLine("- Linguagem elegante, orientada a objeto e fortemente tipada");
            Console.WriteLine("- Sintaxe é similar ao do C e C++");
            Console.WriteLine("- Suporta encapsulamento, polimorfismo e herança");
            Console.WriteLine("- São executados no .Net");
        }

        public void Funcionamento()
        {
            Console.WriteLine("\n=> Funcionamento");

            Console.WriteLine("1- Código-fonte é compilado em uma linguagem intermediária (IL)");
            Console.WriteLine("2- Código e os recursos de IL são armazenados no disco geralmente com extensão .exe ou .dll");
            Console.WriteLine("3- Quando executado, o assembly é carregado no CLR");
            Console.WriteLine("4- Em seguida, o CLR executará a compilação just in time para converter o código IL em linguagem máquina");
        }

        public void TiposEVariaveis()
        {
            Console.WriteLine("\n=> Tipos e Variaveis");

            Console.WriteLine("1 - Variavéis de tipo de valor");
            Console.WriteLine("- Variável separa um espaço na memória e seus dados estão nesse mesmo espaço");
            Console.WriteLine("- A propria variavel contém os seus dados.");
            Console.WriteLine("- As variáveis têm sua própria cópia dos dados");

            Console.WriteLine("\n1.1 - Tipo de valor");
            Console.WriteLine("- short");
            Console.WriteLine("- int");
            Console.WriteLine("- long");
            Console.WriteLine("- double ...");

            Console.WriteLine("\n2- Variavéis de tipo referência");
            Console.WriteLine("- Variável armazena referência a seus dados");
            Console.WriteLine("- É possível que duas variáveis façam referência ao mesmo objeto");

            Console.WriteLine("\n2.1 - Tipo de referência");
            Console.WriteLine("- class");
            Console.WriteLine("- object");
            Console.WriteLine("- string");
            Console.WriteLine("- int[] ...");
        }
    
        public void Instrucoes()
        {
            Console.WriteLine("\n=> Instruções");

            Console.WriteLine("\nCondição: ");
            Console.WriteLine("1- If");
            Console.WriteLine("2- Switch");

            Console.WriteLine("\nRepetição: ");
            Console.WriteLine("1- While");
            Console.WriteLine("2- Do");
            Console.WriteLine("3- For");
            Console.WriteLine("4- Foreach");

            Console.WriteLine("\nTratamento de Exceção: ");
            Console.WriteLine("1- Try .. catch .. finally ");
            Console.WriteLine("2- Throw ");
        }
    }
    
}