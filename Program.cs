using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos de números:");
            decimal quantidade = Convert.ToDecimal(Console.ReadLine());

            decimal NumeroDigitado;
            int contador = 0;

            decimal soma = 0;
            decimal maiorNumero = 999M;
            decimal menorNumero = 999M;

            while (contador < quantidade)
            {
                contador += 1;
                Console.Write($"Número #{contador}: ");
                NumeroDigitado = Convert.ToDecimal(Console.ReadLine());
                soma = soma + NumeroDigitado;

                if (contador == 1)
                {
                    maiorNumero = NumeroDigitado;
                    menorNumero = NumeroDigitado;
                }
            
            
            if (NumeroDigitado > maiorNumero)
            {
                maiorNumero = NumeroDigitado;
            }

            if (NumeroDigitado < menorNumero)
            {
                menorNumero = NumeroDigitado;

            }        

            }
            if (contador > 0)
            {
            decimal media = soma / quantidade;
            
            Console.WriteLine($"\nSoma ..:{soma:N2}");
            Console.WriteLine($"Media..:{media:N2}");
            Console.WriteLine($"Maior..:{maiorNumero:N2}");
            Console.WriteLine($"Menor..:{menorNumero:N2}");
            }
        }
    }
}
