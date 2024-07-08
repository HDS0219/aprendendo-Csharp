using System;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            //tratamento super simples de exceção

            try {
                Console.Write("Digite um número inteiro: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Você digitou: " + n1);
            }
            catch {
                Console.WriteLine("formato invalido");
            }
        }
    }
}