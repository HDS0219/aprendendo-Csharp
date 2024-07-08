String nome;
int idade;

Console.Write("Digite seu nome: ");
nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade < 18) {
    Console.WriteLine("você " + nome + " possui menos de 18 anos e não pode se alistar");
}
else if (idade == 18) {
    Console.WriteLine("Você " + nome + " e possui mais de 18 anos, logo, pode se alistar");
}
else {
    Console.WriteLine("Já passou da hora de se alistar!");
}
