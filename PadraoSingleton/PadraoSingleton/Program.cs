using System;

namespace PadraoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var contador = 2;
            
            while(contador >= 0)
            {
                Console.WriteLine(Singleton.Instance.Id);
                contador--;
            }
        }
    }
}
