
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio2
    {
        public static void Principal()
        {
            int numero;

            do
            {
                Console.WriteLine("Informe um número para verificar se é primo:");
            } while (!int.TryParse(Console.ReadLine(), out numero));

            if (EhPrimo(numero))
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }

        private static bool EhPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
