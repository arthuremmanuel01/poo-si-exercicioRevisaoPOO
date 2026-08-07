public class Calculadora
{
    private int[] _valores;

    public Calculadora(int[] valores)
    {
        _valores = valores;
        Array.Sort(_valores);
    }

    public int[] Valores => _valores;


    public int CalcularProdutoDosImpares()
    {
        int produto = 1;
        bool existeImpar = false;

        foreach (int num in _valores)
        {
            if (num % 2 != 0)
            {
                produto *= num;
                existeImpar = true;
            }
        }

        return existeImpar ? produto : 0;
    }

    public int[] EncontrarDivisiveisPeloMenor()
    {
        int menor = _valores[0];
        List<int> divisiveis = new List<int>();

        foreach (int num in _valores)
        {
            if (menor != 0 && num % menor == 0)
            {
                divisiveis.Add(num);
            }
        }

        return divisiveis.ToArray();
    }


}