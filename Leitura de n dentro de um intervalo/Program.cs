/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
Exemplos:
Entrada:
5
14
123
10
-25
32
Saida:
2 in
3 out
Entrada: 
4
86
35
20
7
Saida:
1 in
3 out
*/
using System;
class Repeticao
{
    static void Main()
    {
        int N;
        int add = 0;
        int odd = 0;
        int repeticao;

        Console.WriteLine("Digite o numero de repetições:");
        repeticao = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < repeticao; i++)
        {
            Console.WriteLine("Digite um numero:");
            N = Convert.ToInt32(Console.ReadLine());
            if (N >= 10 && N <= 20)
            {
                add++;
            }
            else
            {
                odd++;
            }

        }
        Console.WriteLine(add + " in " + odd + " out");
    }
}