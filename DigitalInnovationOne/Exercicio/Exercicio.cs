using System;

namespace DigitalInnovationOne
{
    class Exercicio
    {
        public void UtilizandoFor(int numeroDeVezes)
        {
            Console.WriteLine("\nMétodo UtilizandoFor");

            for (int i=0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"For => Valor de i é {i}");
            }
        }

        public void UtilizandoWhile(int numeroDeVezes)
        {
            Console.WriteLine("\nMétodo UtilizandoWhile");

            for (int i=0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"While => Valor de i é {i}");
            }
        }

        public void InstrucaoIf(string[] args)
        {
            Console.WriteLine("\nMétodo InstrucaoIf");

            int quantidade = args.Length;

            if(quantidade == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else 
            {
                Console.WriteLine($"{quantidade} argumentos");
            }
        }

        public void InstrucaoUsing()
        {
            Console.WriteLine("\nMétodo InstrucaoUsing");

            using (System.IO.TextWriter w = System.IO.File.CreateText("arquivo.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
   
        public void InstrucaoSwitch(string[] args)
        {
            Console.WriteLine("\nMétodo InstrucaoSwitch");

            int quantidade = args.Length;

            switch (quantidade)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{quantidade} argumentos");
                    break;
            }
        }

    }
}
