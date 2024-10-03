using System;
using biblioteca;
class Program
{
    static int menu()
    {
        Console.WriteLine("\t *** Calculadora C# ***\n");
        Console.WriteLine("1- Somar");
        Console.WriteLine("2- Dividir");
        Console.Write("Digite uma opção: ");
        int opcao = int.Parse(Console.ReadLine()); 
        return opcao;
    }//criação menu calculadora
    static void Main()
    {
        do
        {
            int opcao = menu();
            Console.WriteLine("Digite dois valores: ");
            double num1 = double.Parse(Console.ReadLine()); 
            double num2 = double.Parse(Console.ReadLine());
            switch (opcao) 
            {
                case 1: double res = Calculadora.soma(num1, num2);
                    Console.WriteLine($"Resultado: {res:F2}"); break;
                case 2: res = Calculadora.dividir(num1, num2);
                    Console.WriteLine($"Resultado: {res:F2}"); break;
                    }//fim switch
            Console.ReadKey();
            Console.Clear();
        }while (true);

    }
}
