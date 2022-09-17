using System;

namespace Шрифты_
{
    class Шрифты
    {
        public static void Main()
        {
            string line;
            Console.Write("Введите набор чисел(включая - слэш,запятую,точку): ");
            line = Console.ReadLine();
            Console.Clear();
            


            var dimensionX = 7 * line.Length;
            Console.SetWindowSize((dimensionX + ((line.Length - 1) * 7)) + 20, 24);

            var x = (Console.WindowWidth / 2) - dimensionX / 2;
            var y = (Console.WindowHeight / 2) - 5;

            foreach (char uu in line)
            {
                Console.SetCursorPosition(x, y);
                switch (uu)
                {
                    case '0':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█▀▀█");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("█  █");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("█  █");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("█  █");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("▀▀▀▀");
                        break;

                    case '1':
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ▀█  ");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("  █  ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("  █  ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("  █  ");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("  ▀  ");
                        break;

                    case '2':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("    █");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("█▀▀▀▀");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("█   ▄");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("▀▀▀▀▀");
                        break;

                    case '3':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("    █");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write(" ▀▀▀█");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("▄   █");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("▀▀▀▀▀");
                        break;

                    case '4':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█   █");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("█   █");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("▀▀▀▀█");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("    █");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("    ▀");
                        break;

                    case '5':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("█    ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("▀▀▀▀█");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("▄   █");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("▀▀▀▀▀");
                        break;

                    case '6':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("█    ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("█   █");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("▀▀▀▀▀");
                        break;

                    case '7':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("    █");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("    █");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("    █");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("    ▀");
                        break;

                    case '8':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("█   █");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("█   █");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("▀▀▀▀▀");
                        break;

                    case '9':
                        Console.SetCursorPosition(x, y);
                        Console.Write("█▀▀▀█");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("█   █");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("▀▀▀▀█");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("    █");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("    ▀");
                        break;

                    case '/':
                        Console.SetCursorPosition(x, y);
                        Console.Write("    █");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("   ■ ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("  ■  ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write(" ■   ");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("█    ");
                        break;

                    case ' ':
                        Console.SetCursorPosition(x, y);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("     ");
                        break;

                    case '.':
                        Console.SetCursorPosition(x, y);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("  ▄  ");
                        break;

                    case ',':
                        Console.SetCursorPosition(x, y);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 1);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 2);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 3);
                        Console.Write("     ");
                        Console.SetCursorPosition(x, y + 4);
                        Console.Write("  ▄  ");
                        Console.SetCursorPosition(x, y + 5);
                        Console.Write("  ▀  ");
                        break;
                }
                x += 7;
            }
            Console.WriteLine(" ");
        }
    }
}