using System; // Importa o namespace System para acessar classes e métodos fundamentais
using System.Globalization; // Importa o namespace System.Globalization para manipulação de informações culturais

namespace Course {
    internal class Program {
        // Método principal onde o programa começa a execução
        static void Main(string[] args) {
            
            // Declaração e inicialização de variáveis
            char genero = 'F'; // Variável do tipo caractere representando o gênero
            int idade = 32; // Variável do tipo inteiro representando a idade
            double saldo = 10.35784; // Variável do tipo double representando o saldo
            string nome = "Maria"; // Variável do tipo string representando o nome
            
            // Exibindo mensagem no console usando placeholders
            // {0}, {1}, {2:F2} são placeholders que serão substituídos pelos valores de 'nome', 'idade' e 'saldo'
            // {2:F2} formata 'saldo' com 2 casas decimais
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            
            // Exibindo mensagem no console usando interpolação de strings
            // $ antes da string permite inserir variáveis diretamente dentro de chaves {}
            // {saldo:F2} formata 'saldo' com 2 casas decimais
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            
            // Exibindo mensagem no console usando concatenação de strings
            // Usa o operador + para concatenar várias partes da string e variáveis
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
