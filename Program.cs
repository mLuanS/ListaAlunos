using System;

class Program
{
    static void Main(string[] args)
    {
        
        string[] nomes = new string[10];
        int[] idades = new int[10];

        
        for (int i = 0; i < 10; i++)
        {
            // Solicita o nome do aluno
            Console.WriteLine("Digite o nome do aluno {0}: ", i + 1);
            nomes[i] = Console.ReadLine();

            
            Console.WriteLine("Digite a idade do aluno {0}: ", i + 1);
            idades[i] = int.Parse(Console.ReadLine());
        }

        // Imprime a lista de alunos
        Console.WriteLine("Lista de alunos:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Nome: {0}, Idade: {1}", nomes[i], idades[i]);
        }

        Console.ReadLine();
    }
}
