using System;
using System.Globalization;

namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, resultado, resto, nota;

            Console.WriteLine("Digite um número para calcularmos o menor número de cédulas possíveis: ");
            valor = int.Parse(Console.ReadLine());
            

            resto = valor;

            nota = 100;
            resultado = resto / nota;
            resto = resto % nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");

            nota = 50;
            resultado = resto / nota;
            resto = resto % nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");

            nota = 20;
            resultado = resto / nota;
            resto = resto % nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");

            nota = 10;
            resultado = resto / nota;
            resto = resto % nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");

            nota = 5;
            resultado = resto / nota;
            resto = resto % nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");

            nota = 2;
            resultado = resto / nota;
            resto = resto % nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");

            nota = 1;
            resultado = resto / nota;
            resto = resto % nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");




        }
    }
}