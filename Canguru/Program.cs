/*
Desafio
https://www.hackerrank.com/challenges/kangaroo/problem?isFullScreen=true 
*/

Console.WriteLine(Canguru.Kangaroo(2, 1, 1, 2));


public class Canguru
{
    public static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        int posicaoAtual01 = x1;
        int posicaoAtual02 = x2;

        // cada iteração é um salto
        // ao final de cada salto é preciso verificar se eles se encontraram
        for (int i = 0; i < 10000; i++)
        {
            posicaoAtual01 += v1;
            posicaoAtual02 += v2;

            if (posicaoAtual01.Equals(posicaoAtual02)) return "YES";
        }

        return "NO";
    }
}