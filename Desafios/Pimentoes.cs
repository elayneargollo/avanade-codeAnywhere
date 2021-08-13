using System; 

class Pimentoes{

    static void Main(string[] args) { 

        string[] texto = Console.ReadLine().Split(" ");
        int a = int.Parse(texto[0]), b = int.Parse(texto[1]);
        Console.WriteLine("X = {0}", a + b);
    }
}