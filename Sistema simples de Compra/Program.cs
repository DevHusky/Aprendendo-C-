/*
Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

Exemplos:
Entrada: Saída:
12 1 5.30
16 2 5.10
VALOR A PAGAR: R$ 15.50
Entrada: Saída:
13 2 15.30
161 4 5.20
VALOR A PAGAR: R$ 51.40
Entrada: Saída:
1 1 15.10
2 1 15.10
VALOR A PAGAR: R$ 30.20
*/
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
