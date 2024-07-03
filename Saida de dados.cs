using System;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {
            
            // Declaração e inicialização de variáveis
            char genero = 'F'; // Variável do tipo caractere representando o gênero
            int idade = 32; // Variável do tipo inteiro representando a idade
            double saldo = 10.35784; // Variável do tipo double representando o saldo
            string nome = "Maria"; // Variável do tipo string representando o nome
            
            // Exibindo mensagens no console
            Console.Write("Bom dia!"); // Exibe "Bom dia!" sem pular para a próxima linha
            Console.WriteLine("Boa tarde!"); // Exibe "Boa tarde!" e pula para a próxima linha
            Console.WriteLine("Boa noite!"); // Exibe "Boa noite!" e pula para a próxima linha
            Console.WriteLine("================");
            
            // Exibindo os valores das variáveis no console
            Console.WriteLine(genero); // Exibe o valor da variável 'genero'
            Console.WriteLine(idade); // Exibe o valor da variável 'idade'
            Console.WriteLine(saldo); // Exibe o valor da variável 'saldo'
            Console.WriteLine(nome); // Exibe o valor da variável 'nome'
            
            // Exibindo o valor de 'saldo' formatado com diferentes especificações
            Console.WriteLine(saldo.ToString("F2")); // Exibe 'saldo' com 2 casas decimais
            Console.WriteLine(saldo.ToString("F4")); // Exibe 'saldo' com 4 casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // Exibe 'saldo' com 4 casas decimais e ponto como separador decimal

        }
    }
}
