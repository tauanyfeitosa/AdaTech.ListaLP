
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio5
    {
        public static void Principal()
        {
            Console.Write("Informe uma palavra para verificar se é um palíndromo: ");
            string palavra = Console.ReadLine();

            if (VerificarPalindromo(palavra))
            {
                Console.WriteLine($"{palavra} é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"{palavra} não é um palíndromo.");
            }
        }

        private static bool VerificarPalindromo(string palavra)
        {
            palavra = palavra.Replace(" ", "").ToLower();

            return palavra == InverterString(palavra);
        }

        private static string InverterString(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
