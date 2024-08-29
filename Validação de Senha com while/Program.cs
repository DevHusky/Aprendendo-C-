/*
Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
Exemplos:
Entrada:
2200
1020
2022
2002
Saida:
Senha Invalida
Senha Invalida
Senha Invalida
Acesso Permitido
Entrada: 
2020
1031
2002
Saida:
Senha Invalida
Senha Invalida
Acesso Permitido
*/
using System;
using System.ComponentModel;

class Repeticao
{
    static void Main()
    {
        int senha;
        Console.WriteLine("Digite sua senha :");
        senha = Convert.ToInt32(Console.ReadLine());

        while (senha != 2002)
        {
            Console.WriteLine("Senha Inválida!!");
            Console.WriteLine("Digite sua senha :");
            senha = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Acesso Liberado!");
    }
}