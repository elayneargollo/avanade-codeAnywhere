using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numeroDeVezes = 5;
            string[] argumentos = {"Argumento 1", "Argumento 2"};

            Explicacao explicacao = new Explicacao();
            explicacao.Conceito();
            explicacao.Funcionamento();
            explicacao.TiposEVariaveis();
            explicacao.Instrucoes();

            Exercicio exercicio = new Exercicio();
            exercicio.UtilizandoFor(numeroDeVezes);
            exercicio.UtilizandoWhile(numeroDeVezes);
            exercicio.InstrucaoIf(argumentos);
            exercicio.InstrucaoIf(args);
            exercicio.InstrucaoSwitch(args);
            exercicio.InstrucaoUsing();

            Ponto ponto3D = new Ponto3D(1,2,3);
            ponto3D.CalcularDistancia3();
        }
    }
    
}
