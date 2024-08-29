using System;
using Microsoft.VisualBasic;

class Compras
{

    static void Main()
    {
        int cod1, cod2, quant1, quant2;
        float prec1, prec2;

        Console.WriteLine("Digite o Código do Produto : ");
        cod1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a Quantidade de Produtos : ");
        quant1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o Preço do Produto: ");
        prec1 = (float)Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o Código do  Segundo Produto : ");
        cod2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a Quantidade de Produtos : ");
        quant2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o Preço do Produto: ");
        prec2 = (float)Convert.ToDecimal(Console.ReadLine());

        float total1 = quant1 * prec1;
        float total2 = quant2 * prec2;
        float total3 = total1 + total2;


        //Console.WriteLine("compras código 12, Valor = R$" + total1);
        Console.WriteLine("Compras código" + cod1 + ", Valor de = R$ " + (quant1 * prec1));
        //Console.WriteLine("compras código 16, Valor = R$ " + total2);
        Console.WriteLine("Compras código" + cod2 + ", Valor de = R$ " + (quant2 * prec2));
        //Console.WriteLine("Valor total das Compras = R$ " + total3);
        Console.WriteLine("Valor total das Compras = R$ " + ((quant2 * prec2) + (quant1 * prec1)));

    }
}
