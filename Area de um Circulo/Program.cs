/*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula:  = .
Considere o valor de π = 3.14159

Exemplos:
Entrada: Saída:
2.00 A=12.5664
Entrada: Saída:
100.64 A=31819.3103
Entrada: Saída:
150.00 A=70685.7750
*/
using System;

class Area
{
    static void Main()
    {
        double pi = 3.14159, r;

        r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A = " + (pi * (r * r)).ToString("0.0000"));
    }
}