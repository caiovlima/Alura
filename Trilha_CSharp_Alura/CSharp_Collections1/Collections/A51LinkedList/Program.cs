using System;
using System.Collections.Generic;

namespace A51LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };
            //vamos imprimir essa lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            //instanciando uma nova lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();
            //adicionando um dia qualquer: "quarta"
            var d4 = dias.AddFirst("quarta");

            //mas e o valor "quarta"? está na propriedade d4.Value
            Console.WriteLine("d4.Value: " + d4.Value);

            //Adicionando dias na nossa lista linkada de dias
            var d2 = dias.AddBefore(d4, "segunda");
            var d3 = dias.AddAfter(d2, "terça");
            var d6 = dias.AddAfter(d4, "sexta");
            var d7 = dias.AddAfter(d6, "sábado");
            var d5 = dias.AddBefore(d6, "quinta");
            var d1 = dias.AddBefore(d2, "domingo");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            //procurar um determinado dia
            var quarta = dias.Find("quarta");

            //remover determinado dia
            dias.Remove("quarta");
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
        }
    }
}
