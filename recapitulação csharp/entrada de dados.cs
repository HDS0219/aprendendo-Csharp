using System; // Importa o namespace System para acessar classes e métodos fundamentais

namespace Course {
    internal class Program {
        // Método principal onde o programa começa a execução
        static void Main(string[] args) {

            // Lê uma string da entrada padrão
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Você digitou: " + frase);

            // Lê um inteiro da entrada padrão
            Console.Write("Digite um número inteiro: ");
            int numeroInteiro = int.Parse(Console.ReadLine()); // Converte a string lida para int usando int.Parse
            Console.WriteLine("Você digitou o número inteiro: " + numeroInteiro);

            // Lê um número float da entrada padrão
            Console.Write("Digite um número float: ");
            float numeroFloat = float.Parse(Console.ReadLine()); // Converte a string lida para float usando float.Parse
            Console.WriteLine("Você digitou o número float: " + numeroFloat);

            // Lê um número double da entrada padrão
            Console.Write("Digite um número double: ");
            double numeroDouble = double.Parse(Console.ReadLine()); // Converte a string lida para double usando double.Parse
            Console.WriteLine("Você digitou o número double: " + numeroDouble);

            // Lê um caractere da entrada padrão
            Console.Write("Digite um caractere: ");
            char caractere = char.Parse(Console.ReadLine()); // Converte a string lida para char usando char.Parse
            Console.WriteLine("Você digitou o caractere: " + caractere);
            
            // Lê múltiplos valores em uma única linha e separa-os
            Console.Write("Digite valores separados por espaço: ");
            string s = Console.ReadLine(); // Lê a linha inteira como uma string
            string[] vet = s.Split(' '); // Divide a linha lida em substrings com base no espaço
            foreach (string vetor in vet) { // Itera por cada substring resultante
                Console.WriteLine(vetor); // Exibe cada substring
            }
        }
    }
}
