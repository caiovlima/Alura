using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoALongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");
            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;
            

            for (int contadorAno = 1; contadorAno <=5; contadorAno++)
            {
                for (int contadorMes = 0; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;

                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao termino do investimento, você terá: R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
