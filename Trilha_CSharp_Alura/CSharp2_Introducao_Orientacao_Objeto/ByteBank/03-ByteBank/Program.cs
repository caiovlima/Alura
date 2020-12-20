using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.Titular = "Gabriela";
            contaDaGabriela.NumeroAgencia = 863;
            contaDaGabriela.Numero = 863264;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.Titular = "Gabriela";
            contaDaGabrielaCosta.NumeroAgencia = 863;
            contaDaGabrielaCosta.Numero = 863264;
            contaDaGabriela.Saldo = 100;

            

            Console.ReadLine();

        }
    }
}
