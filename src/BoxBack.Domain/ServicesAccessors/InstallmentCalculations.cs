// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double valorPrincipalFinancimento = 240000.00;
        
        double iof = 4466.59;
        double tarifa = 2615.00;
        double seguro = 0;
        
        double valorTotalFinanciamento = valorPrincipalFinancimento + iof + tarifa + seguro;
			
        // Calculo custo efetivo
        double custoEfetivoAno = 15.450000 / 100;
        
        double seraElevado = (1 + custoEfetivoAno);
        double potencia = 1.0 / 12;
    
		double custoEfetivoMes = Math.Pow(seraElevado, potencia)-1;
		double custoEfetivoDia = Math.Pow(1 + custoEfetivoMes, 1.0 / 30) - 1;
		
		double valorParcela = valorTotalFinanciamento / 48;
		double juros = 86633.57;
		
		double valorTotalComJuros = valorTotalFinanciamento + juros;
            
        Console.WriteLine($"Valor das parcelas: {valorTotalComJuros / 48}");
    }
}