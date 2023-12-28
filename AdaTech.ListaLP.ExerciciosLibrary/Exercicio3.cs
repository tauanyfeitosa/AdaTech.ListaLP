
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio3
    {
        public static void Principal()
        {
            int numero;

            do
            {
                Console.Write("Informe um número inteiro positivo para calcular o fatorial: ");
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0);

            long resultado = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é: {resultado}");
        }

        private static long CalcularFatorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalcularFatorial(n - 1);
            }
        }
    }
}
