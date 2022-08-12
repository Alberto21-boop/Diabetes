using System;

namespace Glicose;

public class Program
{
    static void Main(string[] args)
    {
        double glicose;

        Console.Write("Digite por favor a medida da glicose: ");
        glicose = double.Parse(Console.ReadLine());

        if(glicose <= 100)
        {
            Console.WriteLine("Classificação: Normal");
        }
        else if(glicose <= 140)
        {
            Console.WriteLine("Classificação: Elevado");
        }
        else if(glicose >= 140)
        {
            Console.WriteLine("Classificação: Diabetes");
        }
    }
}