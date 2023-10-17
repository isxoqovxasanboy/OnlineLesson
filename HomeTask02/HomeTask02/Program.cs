//using HomeTask02;

using HomeTask02;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            int chouce = GetResultOneElement();

            var resultAdd = chouce switch
            {
                1 => Calculator.GetAddNumbers(
                            GetResultOneElement("first"),
                            GetResultOneElement("second")),
                2 => Calculator.GetAddNumbers(GetResultList()),
                _ => -1

            };

            if (resultAdd == -1)
            {
                Console.WriteLine("Bye see you late");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"It's two numbers sum {resultAdd}");
            }
            Thread.Sleep(1500);
            Console.Clear();
        }

    }

    static void MenuUI()
    {
        Console.WriteLine("-------------------Calculator App-------------------");
        Console.WriteLine("1. Add two numbers");
        Console.WriteLine("2. Add list of numbers");
        Console.WriteLine("3.Exit");
    }

    static int GetResultOneElement()
    {
        int chouce = 0;
        bool flag = true;
        do
        {
            MenuUI();
            flag = int.TryParse(Console.ReadLine() ?? string.Empty, out chouce);

            if (chouce <= 0 || chouce > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter numbers from 1 to 3!");

            }
            else if (chouce > 0 || chouce <= 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Correct number");
            }

            Thread.Sleep(1000);
            Console.Clear();
            Console.ResetColor();
        } while (!flag || chouce <= 0 || chouce > 3);

        return chouce;
    }

    static int GetResultOneElement(string chosenWord)
    {
        Console.WriteLine($"Please enter {chosenWord} number");
        return int.Parse(GetWord(false));
    }



    static int[] GetResultList()
    {
        return GetWord().Split(',').Select(number => Convert.ToInt32(number)).ToArray();
    }

    static string GetWord(bool consent = true)
    {
        string result;
        do
        {
            Console.WriteLine("Please enter number");
            result = Console.ReadLine() ?? string.Empty;
            if (!result.NullOrWhiteSpaceAndNumbers(consent))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("please don't enter a blank line or characters");
                Console.ResetColor();
            }
            Thread.Sleep(1000);
            Console.Clear();
        } while (!result.NullOrWhiteSpaceAndNumbers(consent));
        return result;
    }





}


