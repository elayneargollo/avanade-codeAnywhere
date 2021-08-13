using System;

public class Ponto
{
    public float x, y;
    public float distancia;

    public Ponto(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    protected void CalcularDistancia() 
    { 
        Console.WriteLine("\nCalcularDistancia - Classe Ponto");
    }

    public virtual void CalcularDistancia3()
    {
        Console.WriteLine("CalcularDistancia3 da Classe Ponto");
    }
}