/*
Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau ( +  +  = 0)
Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja
abaixo). Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
negativo), mostrar uma mensagem "Impossivel calcular".
Fórmula:  = ±√∆
 onde: ∆=  − 4

Exemplos:
Entrada: Saída:
10.0 20.1 5.1 X1 = -0.29788
X2 = -1.71212
Entrada: Saída:
0.0 20.0 5.0 Impossivel calcular
Entrada: Saída:
10.3 203.0 5.0 X1 = -0.02466
X2 = -19.68408
Entrada: Saída:
10.0 3.0 5.0 Impossivel calcular 
*/

using System;

class Baskara
{
    static void Main()
    {
        double a, b, c;
        double x1, x2;
        Console.WriteLine("Digite o valor de a :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de b :");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de c :");
        c = Convert.ToDouble(Console.ReadLine());

        double delta = (b * b) - (4 * a * c);

        Console.WriteLine();

        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X1 é igual a " + x1);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X2 é igual a " + x2);
        }
        Console.WriteLine();

    }


}