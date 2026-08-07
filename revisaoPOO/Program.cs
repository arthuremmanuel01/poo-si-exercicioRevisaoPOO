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

        static void Main(string[] args)
        {
            int[] valores = LerValores();

        }
    }
}
