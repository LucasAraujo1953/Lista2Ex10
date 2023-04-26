using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double M;

            Console.Write("Entre com o valor da prova 1: ");
            p1=double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor da prova 2: ");
            p2=double.Parse(Console.ReadLine());

            M = (p1 + 2 * p2) / 3;

            if (M < 5)
                Console.WriteLine("Aluno Reprovado");
            else if (M >= 5)
                Console.WriteLine("Aluno aprovado");
        }
    }
}
