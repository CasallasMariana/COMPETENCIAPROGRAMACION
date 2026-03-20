using System;

public class Contador
{
    private int valor;

    public Contador()
    {
        valor = 0;
    }

    public int Incrementar()
    {
        valor++;
        return valor;
    }

    public int Decrementar()
    {
        valor--;
        return valor;
    }

    public int Resultado()
    {
        return valor;
    }
}

