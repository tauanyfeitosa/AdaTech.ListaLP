
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio7
    {
        public static void Principal()
        {
            double valorReais;

            do
            {
                Console.Write("Informe o valor em reais: ");
            } while (!double.TryParse(Console.ReadLine(), out valorReais));

            double cotacaoDolar;

            do
            {
                Console.Write("Informe a cotação do dólar: ");
            } while (!double.TryParse(Console.ReadLine(), out cotacaoDolar) || cotacaoDolar <= 0);

            double valorDolares = ConverterParaDolares(valorReais, cotacaoDolar);
            Console.WriteLine($"O valor de {valorReais:C2} em reais é equivalente a {valorDolares:C2} em dólares.");
        }

        private static double ConverterParaDolares(double valorReais, double cotacaoDolar)
        {
            return valorReais / cotacaoDolar;
        }
    }
}
