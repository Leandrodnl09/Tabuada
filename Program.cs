// Exercício do site URI "Tabuada"
// Programa básico, aqui iremos usar o "for" para fazermos uma tabuada!

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + " X " + N + " = " + i * N);
}
