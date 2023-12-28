
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio6
    {
        public static void Principal()
        {
            double numero;

            do
            {
                Console.Write("Informe um número não negativo para calcular a raiz quadrada: ");
            } while (!double.TryParse(Console.ReadLine(), out numero) || numero < 0);

            double resultado = CalcularRaizQuadrada(numero);

            if (resultado == -1)
            {
                Console.WriteLine("O número informado não possui uma raiz quadrada exata. A raiz aproximada é: " +
                                  $"{CalcularRaizAproximada(numero):F4}");
            }
            else
            {
                Console.WriteLine($"A raiz quadrada de {numero} é: {resultado}");
            }
        }

        private static double CalcularRaizQuadrada(double numero)
        {
            if (numero == 0 || numero == 1)
            {
                return numero;
            }
            else
            {
                double valor = -1;
                for (double i = 2; i <= numero / 2; i++)
                {
                    if (i * i == numero)
                    {
                        valor = i;
                        break;
                    }
                }

                return valor;
            }
        }

        private static double CalcularRaizAproximada(double numero)
        {
            double estimativa = numero / 2;
            double erro = 1e-10;

            while (Math.Abs(estimativa * estimativa - numero) > erro * estimativa)
            {
                estimativa = 0.5 * (estimativa + numero / estimativa);
            }

            return estimativa;
        }
    }
}
