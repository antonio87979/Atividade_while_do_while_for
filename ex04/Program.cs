//Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve 
//pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A 
//solução deve ser implementada usando while, do while e for.

using System;
					
public class Program
{
	public static void Main()
	{
		double somaIdades = 0;
		int contador = 0;
        int idade;
		
//Usando While
/*
Console.WriteLine("Digite as idades (0 para sair):");
while (true)
{
 idade = Convert.ToInt32(Console.ReadLine());
 if (idade== 0) break;
 somaIdades += idade;
 contador++;
}
		double mediaIdade = contador > 0? somaIdades / contador: 0; 
		Console.WriteLine($"Média das idades: {mediaIdade}");
*/
// Usando do while 
/*
do
{
 Console.WriteLine("Digite as idades (0 para sair):");
 idade  = Convert.ToInt32(Console.ReadLine());
 if (idade != 0) 
   {
    somaIdades += idade;
    contador++;
   }
 } while (idade != 0);
        double mediaIdade = contador > 0? somaIdades / contador: 0; 
		Console.WriteLine($"Média das idades: {mediaIdade}");
*/
// Usando for

for (;;)
{
 Console.WriteLine("Digite as idades (0 para sair):"); 
 idade = Convert.ToInt32(Console.ReadLine());
 if (idade == 0) break;
 somaIdades += idade;
 contador++;
} 
  double mediaIdade = contador > 0? somaIdades / contador: 0; 
  Console.WriteLine($"Média das idades: {mediaIdade}");

	}
}
