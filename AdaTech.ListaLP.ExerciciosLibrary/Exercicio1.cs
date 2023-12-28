using ConsoleMenuUsuarioLibrary;

namespace AdaTech.ListaLP.ExerciciosLibrary
{
    public static class Exercicio1
    {
        public static void Principal ()
        {
            var opcoesUsuario = new string[]
            {
                "1. Celsius para Fahrenheit",
                "2. Fahrenheit para Celsius",
                "3. Sair"
            };

            ApresentarEnunciado();
            var selecaoUsuario = RetornarSelecaoUsuario(opcoesUsuario);
            ExecutarSelecao(selecaoUsuario, opcoesUsuario);

        }

        private static void ApresentarEnunciado()
        {
            Console.WriteLine("Neste exercícios você pode selecionar duas opções:\n\n" +
                "Celsius para Fahrenheit  \nou \nFahrenheit para Celsius\n\nInforme em seguida a temperatura que deseja converter e " +
                "será feita a conversão de acordo com a sua escolha!");
            Console.WriteLine("\n\nPressione ENTER para continuar...");
            Console.ReadKey();
        }

        private static int RetornarSelecaoUsuario(string[] opcoesUsuario)
        {
            var opcoes = new ConsoleMenu(opcoesUsuario);
            return opcoes.ShowMenu();

        }

        private static void ExecutarSelecao (int selecaoUsuario, string[] opcoes)
        {
            decimal resultado;
            switch (selecaoUsuario)
            {
                case 0:
                    resultado = ImprimirResultadoCF(RetornarNumeroUsuario(opcoes, selecaoUsuario));
                    break;
                case 1:
                    resultado = ImprimirResultadoFC(RetornarNumeroUsuario(opcoes, selecaoUsuario));
                    break;
                default:
                    throw new Exception("Não foi possível encontrar a seleção");
            }

            Console.WriteLine($"O resultado da conversão de {opcoes[selecaoUsuario].Replace("1.", "").Replace("2.", "")} é: {resultado:F2} graus {opcoes[selecaoUsuario].Split(" ")[3]}");
        }

        private static decimal RetornarNumeroUsuario(string[] opcoes, int selecaoUsuario) 
        {
            decimal numero;
            do
            {
                Console.WriteLine($"Informe a temperatura que deseja passar de {opcoes[selecaoUsuario].Replace("1.", "").Replace("2.", "")}");
            } while (!decimal.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

        private static decimal ImprimirResultadoCF (decimal numero)
        {
            return ((numero * 9) / 5) + 32;
        }

        private static decimal ImprimirResultadoFC (decimal numero)
        {
            return ((numero - 32) * 5) / 9;
        }

    }
}
