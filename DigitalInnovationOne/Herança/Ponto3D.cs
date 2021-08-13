using System;

public class Ponto3D : Ponto
{
    public float z;

    public Ponto3D(float z, float x, float y) : base(x, y)
    {
        this.z = z;
        CalcularDistancia();
    }

    public static void Calcular()
    {
        Console.WriteLine("Calcular da Classe Ponto3D - Static");
    }

    public override void CalcularDistancia3()
    {
        Console.WriteLine("CalcularDistancia3 da Classe Ponto3D");
    }
}