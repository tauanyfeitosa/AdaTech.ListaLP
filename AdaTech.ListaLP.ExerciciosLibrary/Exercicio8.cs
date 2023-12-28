
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio8
    {
        public static void Principal()
        {
            ApresentarEnunciado();

            string senha;

            do
            {
                Console.Write("Digite uma senha: ");
                senha = Console.ReadLine();
            } while (!ValidarSenha(senha));

            Console.WriteLine("Senha válida!");
        }

        static void ApresentarEnunciado()
        {
            Console.WriteLine("Por favor, crie uma senha que atenda aos seguintes critérios:");
            Console.WriteLine("- Tenha pelo menos 8 caracteres.");
            Console.WriteLine("- Contenha pelo menos uma letra maiúscula.");
            Console.WriteLine("- Contenha pelo menos uma letra minúscula.");
            Console.WriteLine("- Contenha pelo menos um número.\n");
        }

        static bool ValidarSenha(string senha)
        {
            if (senha.Length < 8)
            {
                Console.WriteLine("A senha deve ter pelo menos 8 caracteres.");
                return false;
            }

            if (!senha.Any(char.IsUpper))
            {
                Console.WriteLine("A senha deve conter pelo menos uma letra maiúscula.");
                return false;
            }

            if (!senha.Any(char.IsLower))
            {
                Console.WriteLine("A senha deve conter pelo menos uma letra minúscula.");
                return false;
            }

            if (!senha.Any(char.IsDigit))
            {
                Console.WriteLine("A senha deve conter pelo menos um número.");
                return false;
            }

            return true;
        }
    }
}
