using System;

     public class Contador
     {
         private int valor;

         public Contador()
         {
             this.valor = 0;
         }

         public int Incrementar()
         {
             valor = valor + 1;
             return valor;
         }

         public int Decrementar()
         {
             valor = valor - 1;
             return valor;
         }

         public int Resultado()
         {
             return valor;
         }
     }

     public class Program
     {
         public static void Main(string[] args)
         {
             Contador contador = new Contador();

             Console.WriteLine("Valor inicial: " + contador.Resultado());
             Console.WriteLine("Incrementar: " + contador.Incrementar());
             Console.WriteLine("Decrementar: " + contador.Decrementar());
         }
     }

