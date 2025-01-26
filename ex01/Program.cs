//Um funcionário deseja contar quantos dias de trabalho ele teve em um mês. Para 
//isso, ele deve inserir os dias trabalhados (de 1 a 31) até que digite 0, que indica que 
//terminou de informar os dias. O aluno deve implementar essa contagem utilizando 
//as estruturas de repetição while, do while e for.
using System;
					
public class Program
{
	public static void Main()
	{
		int diasTrabalhados = 0;
int dia;

/*Console.WriteLine("Digite os dias trabalhados (0 para sair)");//pedindo os dias
while (true) //enquanto for válido 
{
  dia = Convert.ToInt32(Console.ReadLine());//pedindo os dias
  if (dia == 0) break;//caso for 0, encerrando loop
  diasTrabalhados ++;//loop de mais um 
}
Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}"); //valor final*/

/*do
{
  Console.WriteLine("Digite os dias trabalhados (0zero para sair)");
  dia = Convert.ToInt32(Console.ReadLine());
  if (dia != 0) diasTrabalhados ++;
} while (dia != 0);
		Console.WriteLine($"dias trabalhados: {diasTrabalhados}");*/
		for(;;)
{
  Console.WriteLine("Digite os dias trabalhados (0zero para sair)");
  dia = Convert.ToInt32(Console.ReadLine());
  if (dia == 0) break;
  diasTrabalhados ++;
}
Console.WriteLine($"dias trabalhados: {diasTrabalhados}");
	}
}
