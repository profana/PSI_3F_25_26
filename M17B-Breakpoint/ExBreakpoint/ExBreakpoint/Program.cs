using System;

class Programa
{
    static void Main()
    {
        int valorA = LerValorA();
        int valorB = LerValorB();

        int resultado = CalcularResultado(valorA, valorB);

        Console.WriteLine("Resultado: ",resultado);
    }

    static int LerValorA()
    {
        return 10; 
    }

    static int LerValorB()
    {
        return ObterDivisor();
    }

    static int ObterDivisor()
    {
        return 0; 
    }

    static int CalcularResultado(int x, int y)
    {
        return Dividir(x, y);
    }

    static int Dividir(int x, int y)
    {
        // ***** coloca o breakpoint aqui *****
        return x / y;
    }
}
