using System.Dynamic;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            double result = 0;
            char operation;

            Console.Write("Введите первое число: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                        result = num1 / num2;
                    break;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
