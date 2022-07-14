
using System;
using System.Collections.Generic;
using System.Linq;
using Pablo_orientacao_a_objeto;

class Program
{
    public static List<Funcionario> listaFuncionarios = new List<Funcionario>();

    List<Funcionario> funcionarios = new List<Funcionario>();

    public static void Main(string[] args)
    {


        string opcoesUsuario = ObterOpcaoUsuario();
        
        while (opcoesUsuario.ToUpper() != "3")
        {
                switch (opcoesUsuario)
                {
                    case "1":
                    InserirFuncionario();
                    break;

                    case "2":
                    RelatoriosDefuncionarios();
                    break;

                    case "C":
                    Console.Clear();
                    break;

                    case "3":
                    Console.WriteLine("Sair do sistema");
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                    
                }
        
            opcoesUsuario = ObterOpcaoUsuario();
        }
        Console.WriteLine("Obrigado por usar o sistema");
        Console.ReadLine();
            
    }

    public static void InserirFuncionario()
    {
        Console.Write("Quantos funcionários serão registrados? -  ");
        int n = int.Parse(Console.ReadLine());



        for (int i = 1; i <= n; i++)
        {
            Console.Write(" Nome: ");
            string nome = Console.ReadLine();
            Console.Write(" Sobrenome: ");
            string sobrenome = Console.ReadLine();

            listaFuncionarios.Add(new Funcionario(nome, sobrenome)); 
            Console.ReadLine();
        }
        
    }

    public static void RelatoriosDefuncionarios()
    {
        Console.WriteLine("Lista atualizada de funcionários:");

        

        IEnumerable<Funcionario> listaFuncionarios = 
            from funcionario in 
            orderby funcionario.Sobrenome ascending, funcionario.Nome ascending
            select funcionario;

        foreach (Funcionario funcionario in listaFuncionarios)
        {
            Console.WriteLine("Nome: " + funcionario.Nome + " " +  funcionario.Sobrenome);
        }
    }

    private static string  ObterOpcaoUsuario()
    {
        Console.WriteLine("Bem vindo Usuario");
        Console.WriteLine("Informe a opção desejada:");

        Console.WriteLine("1 - Insira um funcionário novo ");
        Console.WriteLine("2 - Relatório de funcionários");
        Console.WriteLine("C - Limpar tela");
        Console.WriteLine("3 - Sair do sistema");
        Console.WriteLine();

        string opcoesUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcoesUsuario;

    }

    
}