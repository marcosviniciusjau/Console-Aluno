﻿
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
             Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Olá ,eu sou {0} e tenho {1} anos", nome, idade);
    }
    }
}
