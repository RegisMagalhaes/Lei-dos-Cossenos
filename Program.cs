using System;

namespace leidoscossenos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regis faça um programa que permita calcular um angulo em um triangulo...
            Console.WriteLine("Este programa calcula um ângulo pela Lei dos Cossenos!");

            double a;
            double b;
            double c;
            double cossenoDea;
            double cossenoinverso;
            double grau;
            Console.WriteLine("Digite o valor do lado a:");
            a= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado b:");
            b= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado c:");
            c= double.Parse(Console.ReadLine());

            cossenoDea = ((Math.Pow(a,2))-(Math.Pow(b,2))-(Math.Pow(c,2)))/(-2*b*c);
            cossenoinverso = Math.Acos(cossenoDea);

            grau = cossenoinverso*180/3.1416;

            Console.WriteLine($"o Cosseno do ângulo alpha é {cossenoDea}");
            Console.WriteLine($"o ângulo alpha radianos é {cossenoinverso}");
            Console.WriteLine($"o ângulo alpha em graus é {grau}");         
            


        }
    }
}
