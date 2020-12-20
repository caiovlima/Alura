using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11__CalculaPoupancaDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");
            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes = contadorMes++)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);

                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido +);
            }


            Console.ReadLine();
        }
    }
}
