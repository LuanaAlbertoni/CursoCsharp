using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Criando_variaveis.flutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3: Criando variavel.flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine("O salario é igual a " + salario);

            double idade;
            idade = 15.0 / 2;

            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0/ 3;
            Console.WriteLine("5 / 3 = " + idade);

            Console.WriteLine("A execução acabou, tecle enter para sair");
            Console.ReadLine();
        }
    }
}
