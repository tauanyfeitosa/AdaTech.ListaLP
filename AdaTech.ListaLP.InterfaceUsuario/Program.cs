using ConsoleMenuUsuarioLibrary;
using AdaTech.ListaLP.ExerciciosLibrary;

namespace AdaTech.ListaLP.InterfaceUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abaixo estão os exercícios presentes nessa lista.\n" +
                "Selecione o exércício desejado para visualizar o enunciado e a solução!");

            Console.WriteLine("\n\nPressione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();

            while (true)
            {
                var arrayExercicios = new string[]
                {
                    "1. Conversão de temperaturas",
                    "2. É número primo?",
                    "3. Fatorial de número natural",
                    "4. Imprimir array ordenado",
                    "5. É palíndromo?",
                    "6. Qual a raiz quadrada?",
                    "7. Real para Dólar",
                    "8. Validação de senha",
                    "9. Validação de CPF",
                    "10. Estatísticas de texto",
                    "11. Sair"
                };

                var selecaoUsuario = ApresentarMenu(arrayExercicios);

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                if (selecaoUsuario == 10)
                {
                    break;

                } else
                {

                    SelecionarExercicio(selecaoUsuario);
                }
            }
        }

        private static int ApresentarMenu (string[] arrayExercicios)
        {

            var opcoes = new ConsoleMenu(arrayExercicios);
            return opcoes.ShowMenu();
        }

        private static void SelecionarExercicio (int selecaoUsuario)
        {
            switch (selecaoUsuario)
            {
                case 0:
                    Exercicio1.Principal();
                    break;
                case 1:
                    Exercicio2.Principal();
                    break;
                case 2:
                    Exercicio3.Principal();
                    break;
                case 3:
                    Exercicio4.Principal();
                    break;
                case 4:
                    Exercicio5.Principal();
                    break;
                case 5:
                    Exercicio6.Principal();
                    break;
                case 6:
                    Exercicio7.Principal();
                    break;
                case 7:
                    Exercicio8.Principal();
                    break;
                case 8:
                    Exercicio9.Principal();
                    break;
                case 9:
                    Exercicio10.Principal();
                    break;
                default:
                    break;
            }
            Console.WriteLine("\n\nPressione ENTER para continuar...");
            Console.ReadKey();
        }
    }
}
