using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Condicional");

            int idadeJoao = 16;
            int quantidadePessoas = 3;


            if (idadeJoao >= 18 || quantidadePessoas >=2)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("infelizmente voce nao pode entrar");
            }

            Console.ReadLine();
        }
    }
}
