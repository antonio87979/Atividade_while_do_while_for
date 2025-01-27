// Um atendente de suporte técnico deseja contar quantas chamadas atendeu em 
//um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada 
//chamada em minutos até que ele digite 0. O programa deve calcular o total de
//minutos atendidos, utilizando while, do while e for.

using System;
					
public class Program
{
	public static void Main()
	{
    int totalchamadas = 0;
    int duracao;
//usando while		

Console.WriteLine("Digite a duração das chamadas em minutos (0 para sair):"); 
while (true)
{
 duracao = Convert.ToInt32(Console.ReadLine());
 if (duracao == 0) break;
 totalchamadas += duracao;
}
Console.WriteLine($"Total de minutos atendidos: {totalchamadas} minutos");

// Usando do while
/*
do
{
 Console.WriteLine("Digite a duração das chamadas em minutos (0 para sair):");
 duracao = Convert.ToInt32(Console.ReadLine());
 if (duracao != 0) totalchamadas += duracao;
} while (duracao != 0);
Console.WriteLine($"Total de minutos atendidos: {totalchamadas} minutos");

// Usando for

for (;;)
{
 Console.WriteLine("Digite a duração das chamadas em minutos (0 para sair):");
 duracao = Convert.ToInt32(Console.ReadLine());
 if (duracao == 0) break;
 totalchamadas += duracao;
}
Console.WriteLine($"Total de minutos atendidos: {totalchamadas} minutos");
*/
 }
}
