using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            primeiraContaCorrente.Saldo = 200;
            Console.WriteLine(primeiraContaCorrente.Saldo);

            primeiraContaCorrente.Saldo += 100;
            Console.WriteLine(primeiraContaCorrente.Saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.Saldo = 50;

            Console.WriteLine("primeira conta tem " + primeiraContaCorrente.Saldo);
            Console.WriteLine("segunda conta tem " + segundaContaCorrente.Saldo);

            Console.ReadLine();



            Console.ReadLine();

        }
    }
}
