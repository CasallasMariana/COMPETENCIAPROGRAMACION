using System;

public class Program
{
    public static void Main(string[] args)
    {

        Contador contador = new Contador();

        Console.WriteLine("CONTADOR");
        Console.WriteLine("Valor inicial: " + contador.Resultado());
        Console.WriteLine("Incrementar: " + contador.Incrementar());
        Console.WriteLine("Decrementar: " + contador.Decrementar());

        Console.WriteLine();


        Figura circulo = new Circulo(5);
        Figura rectangulo = new Rectangulo(4, 3);

        Console.WriteLine("FIGURAS");
        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
    }
}