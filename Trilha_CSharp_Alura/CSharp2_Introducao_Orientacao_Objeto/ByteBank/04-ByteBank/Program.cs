using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.Titular = "Bruno";
            contaDoBruno.Saldo = 100;

            Console.WriteLine("Saldo Anterior: "+contaDoBruno.Saldo);
            contaDoBruno.Sacar(50);
            Console.WriteLine("Operação de saque...");
            Console.WriteLine("Saldo Atual: " + contaDoBruno.Saldo);

            Console.WriteLine("Saldo Anterior: " + contaDoBruno.Saldo);
            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo Atual: " + contaDoBruno.Saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            
            contaDaGabriela.Titular = "Gabriela";
            Console.WriteLine("Saldo Anterior: " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo Anterior: " + contaDaGabriela.Saldo);
            contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine("Saldo Atual: " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo Atual: " + contaDaGabriela.Saldo);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.Saldo);



        }

    }
}
