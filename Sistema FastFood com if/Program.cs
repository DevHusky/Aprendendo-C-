/*Com base na tabela de preços ao lado, faça
um programa que leia o código de um item e a
quantidade deste item. A seguir, calcule e
mostre o valor da conta a pagar.

Exemplos:
Entrada: Saída:
3 2 Total: R$ 10.00
Entrada: Saída:
2 3 Total: R$ 13.50
*/

using System;

class Fastfood
{
    static void Main()
    {
        int cod;
        int quant;

        Console.WriteLine("CÓDIGO        ESPECIFICAÇÃO           PREÇO");
        Console.WriteLine("  1           Cachorro Quente         R$4.00");
        Console.WriteLine("  2           X-Salada                R$4.50");
        Console.WriteLine("  3           X-Bacon                 R$5.00");
        Console.WriteLine("  4           Torrada Simples         R$2.00");
        Console.WriteLine("  5           Refrigerante            R$1.50");

        Console.WriteLine("Vai querer que número?");
        cod = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vai querer quantos?");
        quant = Convert.ToInt32(Console.ReadLine());


        if (cod == 1)
        {
            Console.WriteLine("Seu Pedido deu: R$ " + (quant * 4).ToString("0.00"));
        }
        if (cod == 2)
        {
            Console.WriteLine("Seu Pedido deu: R$ " + (quant * 4.5f).ToString("0.00"));
        }
        if (cod == 3)
        {
            Console.WriteLine("Seu Pedido deu: R$ " + (quant * 5).ToString("0.00"));
        }
        if (cod == 4)
        {
            Console.WriteLine("Seu Pedido deu: R$ " + (quant * 2).ToString("0.00"));
        }
        if (cod == 5)
        {
            Console.WriteLine("Seu Pedido deu: R$ " + (quant * 1.5f).ToString("0.00"));
        }
        if (cod > 5)
        {
            Console.WriteLine("Pedido Inválido!!");
        }

    }
}