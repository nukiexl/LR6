namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int result = 0;
            char operation;

            Console.Write("Введите первое число: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число: ");
            num2 = int.Parse(Console.ReadLine());

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
                        result = num1 / num1;
                    break;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
