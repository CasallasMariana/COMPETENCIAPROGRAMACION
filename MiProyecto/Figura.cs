using System;

public abstract class Figura
{
    public abstract double CalcularArea();
}

public class Circulo : Figura
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.Round(Math.PI * radio * radio, 2);
    }
}

public class Rectangulo : Figura
{
    private double basesita;
    private double altura;

    public Rectangulo(double basesita, double altura)
    {
        this.basesita = basesita;
        this.altura = altura;
    }

    public override double CalcularArea()
    {
        return basesita * altura;
    }
}