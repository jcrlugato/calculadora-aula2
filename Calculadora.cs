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
        Console.Clear();
        Console.Write("\nDigite para X um número inteiro: ");
        string dadox = Console.ReadLine()!;
        int x = int.Parse(dadox);

        Console.Write("\nDigite para Y um número inteiro: ");
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
        Console.Clear();
        Console.Write("Digite para X um número inteiro: ");
        string dadox = Console.ReadLine()!;
        int x = int.Parse(dadox);

        Console.Write("Digite para Y um número inteiro: ");
        string dadoy = Console.ReadLine()!;
        int y = int.Parse(dadoy);

        int v = x * y;
        Console.WriteLine($"A multiplicação de {x} * {y} é: " + v);

        Console.WriteLine("\nDeseja fazer um novo calculo?");
        Console.Write("\nDigite 1 para Sim e 2 para Não: ");
        string opString = Console.ReadLine()!;
        int op = int.Parse(opString);

        if(op == 1)
        {
         Multplica();
        }
        else{
            Console.Clear();
            ExibirMenu();
        }
        
        return v;
    }
    public int Subtracao()
    {
       Console.Clear();
        Console.Write("Digite para X um número inteiro: ");
        string dadox = Console.ReadLine()!;
        int x = int.Parse(dadox);

        Console.Write("Digite para Y um número inteiro: ");
        string dadoy = Console.ReadLine()!;
        int y = int.Parse(dadoy);

        int v = x - y;
        Console.WriteLine($"A multiplicação de {x} - {y} é: " + v);

        Console.WriteLine("\nDeseja fazer um novo calculo?");
        Console.WriteLine("\nDigite 1 para Sim e 2 para Não: ");
        string opString = Console.ReadLine()!;
        int op = int.Parse(opString);

        if(op == 1)
        {
         Subtracao();
        }
        else{
            Console.Clear();
            ExibirMenu();
        }
        
        return v;
    }
    public double Divisao()
    {
       Console.Clear();
        Console.Write("Digite para X um número inteiro: ");
        string dadox = Console.ReadLine()!;
        int x = int.Parse(dadox);

        Console.Write("Digite para Y um número inteiro: ");
        string dadoy = Console.ReadLine()!;
        int y = int.Parse(dadoy);

        int v = x / y;
        Console.WriteLine($"A multiplicação de {x} / {y} é: " + v);

        Console.WriteLine("\nDeseja fazer um novo calculo?");
        Console.WriteLine("\nDigite 1 para Sim e 2 para Não: ");
        string opString = Console.ReadLine()!;
        int op = int.Parse(opString);

        if(op == 1)
        {
         Multplica();
        }
        else{
            Console.Clear();
            ExibirMenu();
        }
        
        return v;
    }
    public void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("\nDigite 1 para efetuar a Soma");
        Console.WriteLine("Digita 2 para efetuar a Subtração");
        Console.WriteLine("Digite 3 para efetuar a Multiplicação");
        Console.WriteLine("Digite 4 para efetuar a Divisão\n");
        Console.WriteLine("Digite -1 para finalizar");

        Console.Write("\nDigite sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multplica(); break;
            case 4: Divisao(); break;
            case -1: Console.WriteLine("Tchau, Tchau!!! " + opcaoEscolhidaNumerica); break;
            default: Console.WriteLine("Opção Inválida"); break;

        }
    }
    
}
