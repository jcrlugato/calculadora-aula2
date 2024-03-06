using System;
using System.Xml.XPath;

class Calculadora
{
    public int x;
    public int y;
    public int op;

    /*private double divisao;*/

    public Calculadora ()
    {
        x = 0;
        y = 0;
        op = 0;
        /*divisao = 0.0;*/
    }

    public int Soma()
    {
        Console.WriteLine("\nDigite para X um número inteiro: ");
        string dadox = Console.ReadLine()!;
        int x = int.Parse(dadox);

        Console.WriteLine("\nDigite para Y um número inteiro: ");
        string dadoy = Console.ReadLine()!;
        int y = int.Parse(dadoy);

        int v = x + y;
        Console.WriteLine($"\nA some de {x} + {y} é: " + v);

        Console.WriteLine("\nDeseja fazer um novo calculo?");
        Console.WriteLine("\nDigite 1 para Sim e 2 para Não: ");
        string opString = Console.ReadLine()!;
        int op = int.Parse(opString);

        if(op == 1)
        {
         Soma();
        }
        else{
            Console.Clear();
            ExibirMenu();
        }
        
        return v;

    }
    public int Multplica()
    {
       
        Console.WriteLine("Digite para X um número inteiro: ");
        string dadox = Console.ReadLine()!;
        int x = int.Parse(dadox);

        Console.WriteLine("Digite para Y um número inteiro: ");
        string dadoy = Console.ReadLine()!;
        int y = int.Parse(dadoy);

        int v = x * y;
        Console.WriteLine($"A multiplicação de {x} * {y} é: " + v);

        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
        
        return v;
    }
    public int Subtracao()
    {
        return x - y;
    }
    public double Divisao()
    {
        return x / y;
    }
    public void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("\nDigite 1 para efetuar a Soma");
        Console.WriteLine("Digita 2 para efetuar a Subtração");
        Console.WriteLine("Digite 3 para efetuar a Multiplicação");
        Console.WriteLine("Digite 4 para efetuar a Divisão\n");
        Console.WriteLine("Digite sair para finalizar");

        Console.WriteLine("\nDigite sua opção:");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1: Soma();
            break;
            case 2: Multplica();
            break;

        }
    }
    
}
