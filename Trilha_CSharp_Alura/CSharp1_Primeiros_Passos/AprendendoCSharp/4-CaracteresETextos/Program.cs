using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Caracteres e Variaveis");

            char primeiraLetra = 'a';

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "alura cursos de tecnologia !";
            Console.WriteLine(titulo);

            string cursosProgramacao = "\n - .NET" +
                "\n - Java" +
                "\n - JavaScript";

            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
