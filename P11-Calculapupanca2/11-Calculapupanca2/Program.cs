﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Calculapupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Executando projeto 11");

                double valorInvestido = 1000;

                for (int contadorMes = 1; contadorMes <= 12; contadorMes = contadorMes + 1)
                {
                    valorInvestido = valorInvestido + valorInvestido * 0.0036;
                    Console.WriteLine("Após" + contadorMes + "meses, vocë terá R$" + valorInvestido);
                }

                Console.ReadLine();
            }
        }
    }
}