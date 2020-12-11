using System;
using PolimorfismoPOO.classes;

namespace PolimorfismoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();

            Console.WriteLine($"Jogador 1 = {jogador.Correr()}");

            Zero jogador2 = new Zero();

            Console.WriteLine($"Jogador 2 = {jogador2.Correr()}");
        }
    }
}
