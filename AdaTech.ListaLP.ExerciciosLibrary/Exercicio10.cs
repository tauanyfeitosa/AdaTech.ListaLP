
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio10
    {
        public static void Principal()
        {
            Console.WriteLine("Digite um texto:");
            string texto = Console.ReadLine();

            Dictionary<string, int> frequenciaPalavras = ContarFrequenciaPalavras(texto);

            Console.WriteLine("\nFrequência das palavras no texto:");
            foreach (var par in frequenciaPalavras)
            {
                Console.WriteLine($"{par.Key}: {par.Value} vezes");
            }
        }

        private static Dictionary<string, int> ContarFrequenciaPalavras(string texto)
        {
            string[] palavras = texto.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequenciaPalavras = new Dictionary<string, int>();

            foreach (string palavra in palavras)
            {
                string palavraFormatada = palavra.ToLower();
                if (frequenciaPalavras.ContainsKey(palavraFormatada))
                {
                    frequenciaPalavras[palavraFormatada]++;
                }
                else
                {
                    frequenciaPalavras[palavraFormatada] = 1;
                }
            }

            return frequenciaPalavras;
        }
    }
}
