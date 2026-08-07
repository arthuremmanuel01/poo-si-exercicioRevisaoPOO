namespace revisaoPOO
{
    /// <summary>
    /// Escreva um programa que receba três valores inteiros, A, B e C. Este programa deve:
    /// - calcular o produto dos números ímpares entre o menor e o maior número dos três lidos, incluindo ambos;
    /// - responder quais são os números divisíveis pelo menor número na faixa entre os dois maiores, incluindo ambos.
    /// </summary>

    internal class Program
    {
        const int QuantValores = 3;

        static int[] LerValores()
        {
            int[] valores = new int[QuantValores];
            Console.Clear();
            Console.WriteLine($"Você precisará digitar {QuantValores} para a realização dos cálculos:");
            for (int i = 0; i < QuantValores; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            return valores;
        }

        static void ImprimirResposta(int[] valores, int produto, int[] divisiveis)
        {
            Console.WriteLine($"Valores ordenados: {string.Join(", ", valores)}");
            Console.WriteLine($"Produto dos ímpares: {produto}");
            Console.WriteLine($"Divisíveis pelo menor ({valores[0]}): {string.Join(", ", divisiveis)}");
        }

        static void Main(string[] args)
        {
            int[] valoresEntrada = LerValores();
            Calculadora calculadora = new Calculadora(valoresEntrada);

            int produto = calculadora.CalcularProdutoDosImpares();
            int[] divisiveis = calculadora.EncontrarDivisiveisPeloMenor();
            ImprimirResposta(calculadora.Valores, produto, divisiveis);


        }
    }
}
