//Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao 
//usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele 
//digite 0. O programa deve contar quantos votos cada candidato recebeu, 
//implementando a solução com while, do while e for.

using System;
					
public class Program
{
	public static void Main()
	{
    int votosa = 0, votosb = 0;
    int voto;
//usando while
/*
Console.WriteLine("Digite os votos (1 para candidato A, 2 para candidato B, 0 para sair):");
while (true)
{
 voto = Convert.ToInt32(Console.ReadLine());
 if (voto == 0) break;
 if (voto == 1) votosa++;
 else if (voto == 2) votosb++;
}
Console.WriteLine($"Candidato A: {votosa} votos, Candidato B: {votosb} votos");
*/
// Usando do while
/*
do
{
 Console.WriteLine("Digite os votos (1 para candidato A, 2 para candidato B, 0 para sair):");
 voto = Convert.ToInt32(Console.ReadLine());
 if (voto == 1) votosa++;
 else if (voto == 2) votosb++;
}while (voto != 0);
Console.WriteLine($"candidato A: {votosa} votos, Candidato B: {votosb} votos");
*/
// Usando for 

for (;;)
{
 Console.WriteLine("Digite os votos (1 para candidato A, 2 para candidato B, 0 para sair):");
 voto = Convert.ToInt32(Console.ReadLine());
 if (voto == 0) break;
 if (voto == 1) votosa++;
 else if (voto == 2) votosb++;
}
Console.WriteLine($"Candidato A: {votosa} votos, Candidato B: {votosb} votos");

	}
}
