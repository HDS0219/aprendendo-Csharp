using System;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            // Declaração de uma variável booleana que pode ser verdadeira ou falsa
            bool completo = false;

            // Declaração de um caractere que armazena uma letra ou símbolo
            char genero = 'F';

            // Declaração de um caractere utilizando a notação unicode
            char letra = '\u0041'; // Representa 'A' na tabela Unicode

            // Declaração de uma variável byte que pode armazenar um número de 0 a 255 (8 bits)
            byte n1 = 126;

            // Declaração de uma variável inteira (int) que pode armazenar números inteiros de -2.147.483.648 a 2.147.483.647
            int n2 = 1000;
            int n3 = 2147483647; // Valor máximo para um int

            // Declaração de uma variável long que pode armazenar números inteiros maiores que int
            long n4 = 2147483648L; // Nota: O sufixo 'L' indica que é um long

            // Declaração de uma variável float para armazenar números de ponto flutuante, requer o sufixo 'f'
            float n5 = 4.5f;

            // Declaração de uma variável double para armazenar números de ponto flutuante, não requer sufixo
            double n6 = 4.5;

            // Declaração de uma string, que é uma sequência de caracteres imutável e com suporte a Unicode
            string nome = "Maria Green";

            // Declaração de objetos que podem armazenar qualquer tipo de dado
            object obj1 = "Alex Brown"; // Armazenando uma string
            object obj2 = 4.5f;         // Armazenando um float

            // Impressão dos valores das variáveis no console
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            // Declaração e inicialização de variáveis adicionais

            // Declaração de uma variável int com o valor mínimo possível para o tipo
            int n7 = int.MinValue; // Valor mínimo para um int: -2.147.483.648

            // Declaração de uma variável int com o valor máximo possível para o tipo
            int n8 = int.MaxValue; // Valor máximo para um int: 2.147.483.647

            // Declaração de uma variável sbyte com o valor mínimo possível para o tipo
            sbyte n9 = sbyte.MinValue; // Valor mínimo para um sbyte: -128

            // Declaração de uma variável sbyte com o valor máximo possível para o tipo
            sbyte n10 = sbyte.MaxValue; // Valor máximo para um sbyte: 127

            // Declaração de uma variável decimal com o valor máximo possível para o tipo
            decimal n11 = decimal.MaxValue; // Valor máximo para um decimal: 79.228.162.514.264.337.593.543.950.335

            // Impressão dos novos valores das variáveis no console
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(n11);
        }
    }
}
