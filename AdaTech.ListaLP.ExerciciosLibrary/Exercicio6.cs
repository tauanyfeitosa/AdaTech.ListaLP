
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
                Console.WriteLine("O número informado não possui uma raiz quadrada exata. Aguarde um pouco para o cálculo da raiz aproximada.");
                Console.WriteLine($"A raiz aproximada é: {CalcularRaizAproximada(numero):F4}");
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
            else if (numero == 4) 
            {
                return 2;

            } else 
            {
                double valor = -1;
                for (double i = 3; i <= numero / 3; i++)
                {
                    if (i * i == numero)
                    {
                        valor = i;
                        break;
                    } else if (i * i > numero)
                    {
                        valor = -1;
                        break;
                    }
                }
                return valor;
            }
        }

        private static double CalcularRaizAproximada(double numero)
        {
            double estimativa = numero / 2;
            double erro = 1e-15;

            while ((estimativa * estimativa - numero) > 0 && (estimativa * estimativa - numero) > (erro * estimativa) ||
                (estimativa * estimativa - numero) < 0 && (estimativa * estimativa - numero) > (erro * estimativa) *-1)
            {
                estimativa = 0.5 * (estimativa + numero / estimativa);
            }

            return estimativa;
        }
    }
}
