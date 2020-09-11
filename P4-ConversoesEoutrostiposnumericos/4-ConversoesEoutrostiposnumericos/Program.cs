using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEoutrostiposnumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            // O int suporta valores de até 36 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variavel de 64 bits
            long idade;
            idade = 130000000000;
            Console.WriteLine(idade);
            
            // O long suporta até 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            // Float tem uma precissão muito curta
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
