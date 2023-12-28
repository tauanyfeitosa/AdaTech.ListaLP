
namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio9
    {
        public static void Principal()
        {
            ApresentarEnunciado();

            string cpf;

            do
            {
                Console.Write("Digite um CPF (somente números): ");
                cpf = Console.ReadLine();
            } while (!ValidarCPF(cpf));

            Console.WriteLine("CPF válido!");
        }

        private static void ApresentarEnunciado()
        {
            Console.WriteLine("Por favor, insira um CPF para validar.");
            Console.WriteLine("O CPF deve conter apenas números.");
            Console.WriteLine("O programa verificará se o CPF está no formato correto e se passa no critério de validação do dígito verificador.\n");
        }

        private static bool ValidarCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
            {
                Console.WriteLine("O CPF deve conter exatamente 11 dígitos.");
                return false;
            }

            if (cpf.Distinct().Count() == 1)
            {
                Console.WriteLine("CPF inválido: todos os dígitos são iguais.");
                return false;
            }

            int[] numerosCPF = cpf.Substring(0, 9).Select(c => int.Parse(c.ToString())).ToArray();
            int[] digitosVerificadores = new int[2];

            for (int i = 0; i < 2; i++)
            {
                int soma = 0;
                int multiplicador = 2;

                for (int j = numerosCPF.Length - 1; j >= 0; j--)
                {
                    soma += numerosCPF[j] * multiplicador;
                    multiplicador++;
                }

                int resto = soma % 11;

                digitosVerificadores[i] = (resto < 2) ? 0 : 11 - resto;

                if (i == 0)
                {
                    numerosCPF = (cpf.Substring(0, 9) + digitosVerificadores[0].ToString()).Select(c => int.Parse(c.ToString())).ToArray();

                    numerosCPF = numerosCPF.Select(c => int.Parse(c.ToString())).ToArray();
                }
            }

            if (digitosVerificadores[0] != int.Parse(cpf[9].ToString()) || digitosVerificadores[1] != int.Parse(cpf[10].ToString()))
            {
                Console.WriteLine("CPF inválido: dígitos verificadores incorretos.");
                return false;
            }

            return true;
        }
    }
}
