using System; 

class Automovel {

    static void Main(string[] args) { 

        int distancia;
        double combustivelGasto, consumoMedio;

        distancia = Convert.ToInt32(Console.ReadLine());
        combustivelGasto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("{0:0.000} km/l", distancia/combustivelGasto);

    }

}