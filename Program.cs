namespace math_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the math tester!");
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            double firstNumber = random_double(0, 500);
            Console.Write(firstNumber);
            Console.ForegroundColor = ConsoleColor.White;
            int symbol = rnd.Next(0, 2);
            if(symbol == 0)
            {
                Console.Write(" + ");
            }
            else
            {
                Console.Write(" - ");
            }
            double secondNumber = random_double(0, 500);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(secondNumber);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" = ");
            double target = 0;
            if(symbol == 0)
            { 
                target = firstNumber + secondNumber;
            }
            else
            {
                target = firstNumber - secondNumber;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            double userTarget = Convert.ToDouble(Console.ReadLine());
            if(userTarget == target)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect! The correct answer was " + target);
            }

            static double random_double(int min, int max)
            {
                Random rnd = new Random();
                int symbol = rnd.Next(0, 2);
                double number = rnd.Next(min, max);
                if (symbol != 0)
                {
                    number = -number;
                }
                double afterPoint = rnd.Next(0, 100) * 0.01;
                number += afterPoint;
                return number;
            }
        }
    }
}
