
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio4
    {
        public static void Principal()
        {
            int[] numeros;

            do
            {
                Console.Write("Informe números inteiros separados por espaço: ");
                string entrada = Console.ReadLine();

                numeros = ConverterParaArray(entrada);

            } while (numeros == null);

            Array.Sort(numeros);

            Console.WriteLine("Array ordenado em ordem crescente:");

            Console.WriteLine(string.Join(",", numeros));
        }

        private static int[] ConverterParaArray(string entrada)
        {
            string[] partes = entrada.Split(' ');

            int[] numeros = new int[partes.Length];

            for (int i = 0; i < partes.Length; i++)
            {
                if (!int.TryParse(partes[i], out numeros[i]))
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira apenas números inteiros separados por espaço.");
                    return null;
                }
            }

            return numeros;
        }
    }
}
