


Exercicios exercicios = new();


exercicios.Questao04();



public class Exercicios
{
    string auxiliar = "";

    /// <summary>
    ///  Escreva um programa para ler uma matriz A de 4 
    ///  linhas por 5 colunas e imprimir seus elementos.
    /// </summary>
    public void Questao01()
    {
        string[,] A = new string[4, 5];

        for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                Console.WriteLine($"Linha: {linha + 1} Coluna: {coluna + 1}. Digite um valor: ");
                A[linha, coluna] = Console.ReadLine() ?? "vazio";
            }
        }

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                auxiliar += A[linha, coluna];

                if (coluna < 3)
                    auxiliar += " - ";
            }
            auxiliar += "\n";
        }

        Console.WriteLine(auxiliar);
    }

    /// <summary>
    /// Escreva um programa para gerar aleatoriamente os elementos (menor que 100)
    /// de uma matriz B de 6 linha por 3 colunas, imprimir a matriz gerada e
    /// imprimir a matriz em ordem invertida.
    /// </summary>
    public void Questao02()
    {
        auxiliar = "";

        int[,] B = new int[6, 3];

        for (int linha = 0; linha < 6; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
                B[linha, coluna] = new Random().Next(100);
        }

        for (int linha = 0; linha < 6; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                auxiliar += B[linha, coluna];

                if (coluna < 2)
                    auxiliar += " - ";
            }
            auxiliar += "\n";
        }
        Console.WriteLine(auxiliar);
        Console.WriteLine("INVERTIDA\n");
       
        for (int linha = 5; linha >= 0; linha--)
        {
            string auxiliar = "";

            for (int coluna = 2; coluna >= 0; coluna--)
            {
                auxiliar += B[linha, coluna].ToString();

                if (coluna > 0)
                    auxiliar += " - ";
            }
            Console.WriteLine(auxiliar);
        }
    }

    /// <summary>
    /// Escreva um programa para ler uma matriz C quadrada de dimensão N, onde N 
    /// é menor ou igual a 20 e imprimir seus elementos. O usuário deve informar o 
    /// número o tamanho da matriz quadrada (dimensão) e os elementos podem ser 
    /// gerados aleatoriamente (menor que 100).
    /// </summary>
    public void Questao03()
    {
        int[,] C;
        int dimencao;
        auxiliar = "";

        do
        {
            Console.WriteLine("Informe a dimenção menor ou igual a 20: ");
            dimencao = Convert.ToInt32(Console.ReadLine());

        } while (dimencao > 20 || dimencao <= 0);

        C = new int[dimencao, dimencao];

        for (int linha = 0; linha < dimencao; linha++)
        {
            auxiliar = string.Join(" - ", Enumerable.Range(0, dimencao).Select(coluna => C[linha, coluna] = new Random().Next(100)));
            Console.WriteLine(auxiliar);
        }
    }

    /// <summary>
    /// Escreva um programa para ler uma matriz D de dimensão N x M, onde N e M não 
    /// poderem ser menores que um. Gerar os elementos aleatoriamente. O usuário 
    /// deve informar a dimensão (linha e coluna) e um valor máximo para elementos 
    /// aleatórios. O programa efetuar todas as validações. Lembre-se de aproveitar 
    /// os recursos da linguagem para facilitar as validações.
    /// </summary>
    public void Questao04()
    {
        int[,] D;
        int    linha  = 0,  coluna = 0;
        string valor1 = "", valor2 = "";
        int    valorMaximo;               

        do
        {
            Console.WriteLine("Informe a quantidade de linhas: ");
            valor1 = Console.ReadLine() ?? "N/A";
        } 
        while (!CheckNumero(valor1));

        do
        {
            Console.WriteLine("Informe a quantidade de colunas: ");
            valor2 = Console.ReadLine() ?? "N/A";
        } 
        while (!CheckNumero(valor2));

        linha  = Convert.ToInt32(valor1);
        coluna = Convert.ToInt32(valor2);             
    }

    /// <summary>
    /// O método string.Join é usado para concatenar uma 
    /// coleção de strings, separando cada uma delas com um separador 
    /// especificado
    /// </summary>
    public void ComoUsarJoin()
    {
        int[] numeros = new int[] { 1, 2, 5, 15, 15, 4, 84, 8, 4, 84, 8, 48, 4, 8, 478, 7, 8, 7, 7, 8, 84, 416, 41, 4, 4, 89, 49, 5 };

        Console.WriteLine(string.Join(" - ", numeros));
    }

    /// <summary>
    /// A função Enumerable.Range é usada para gerar uma sequência 
    /// de números inteiros dentro de um determinado intervalo
    /// </summary>
    public void ComoUsarRange()
    {      
        IEnumerable<int> numeros = Enumerable.Range(1, 100);

        foreach (int item in numeros)
            Console.WriteLine(item);     
    }

    /// <summary>
    /// O método Select em C# é uma das funções da linguagem 
    /// LINQ (Language Integrated Query), que permite realizar 
    /// operações de consulta em coleções de dados.
    /// </summary>
    public void ComoUsarSelect()
    {
        IEnumerable<decimal> numeros = new decimal[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        IEnumerable<decimal> teste   = numeros.Select(num =>  num* num);

        /* Ele é usado para transformar os elementos de uma sequência, aplicando 
        uma operação ou uma função a cada elemento e retornando uma nova sequência 
        com os resultados das transformações. */

        Console.WriteLine(string.Join("-", teste) + "\n");

        IEnumerable<string> nomes = new string[] { "fulano", "beltrano", "sicrano", "mozano" };
        IEnumerable<string> novaColecao = nomes.Select((nome, indice) => $"Indice: {indice} nome: {nome}");

        foreach (string item in novaColecao)
        {
            Console.WriteLine(item);
        }
    }

    private bool CheckNumero(string valor)
    {
        try
        {
            int numero = Convert.ToInt32(valor);

            if (numero < 1)
                throw new Exception();

            return true;
        }
        catch (Exception) { return false; }
    }
}

