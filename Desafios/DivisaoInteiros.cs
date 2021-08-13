using System;

class DivisaoInteiros
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split();
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int quociente , resto;

        quociente  = a / b;
        resto = (a % b);

        if (resto < 0)
        {
            double q1, r1 = 0.0;

            r1 = resto + Math.Sqrt(b * b);
            q1 = (a - r1) / b;
            Console.WriteLine("{0} {1}", q1, r1);
        }
        else
        {
            Console.WriteLine("{0} {1}", quociente , resto);
        }
    }
}