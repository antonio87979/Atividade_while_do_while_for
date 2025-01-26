//Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar 
//ao usuário que insira suas despesas até que ele digite um valor negativo, 
//sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, 
//utilizando while, do while e for.

using System;
					
public class Program
{
	public static void Main()
	{

		double despesas = 0;
    double despesa;
		// Usando while 
/*Console.WriteLine("Digite suas despesas (valor negativo para sair):");

while (true)
{
 despesa = Convert.ToDouble(Console.ReadLine());
 if (despesa < 0) break;
 despesas += despesa;
}
Console.WriteLine($"Total de despesas: {despesas}");
*/
   // Usando do while 

/*do
{
 Console.WriteLine("Digite suas despesas (valor negativo para sair):"); 
 despesa = Convert.ToDouble(Console.ReadLine());
 if (despesa >= 0) despesas += despesa;
}
while (despesa >= 0);

Console.WriteLine($"Total de despesas: {despesas}");
*/
   // Usando for 

Console.WriteLine("Digite suas despesas (valor negativo para sair):"); //pedindo os valores
for(;;) 
{
 despesa = Convert.ToDouble(Console.ReadLine());
 if (despesa <= 0) break;
 despesas += despesa;
}
Console.WriteLine($"Total de despesas: {despesas}");
	}
}
