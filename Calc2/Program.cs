using System;

class Calculator
{
    public static double Calculate(double a, double b, char operation)
    {
        switch (operation)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/': return b != 0 ? a / b : double.NaN;
            default: throw new ArgumentException("Неверная операция");
        }
    }

    public static void Main()
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("Введите первое число:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                continue;
            }

            Console.WriteLine("Введите операцию (+, -, *, /):");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Введите второе число:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                continue;
            }

            try
            {
                double result = Calculate(num1, num2, operation);
                Console.WriteLine($"Результат: {result}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Нажмите Enter для продолжения или введите 'exit' для выхода.");
            if (Console.ReadLine() == "exit")
            {
                keepRunning = false;
            }
        }
    }
}
