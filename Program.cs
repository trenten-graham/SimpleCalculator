namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keep the calculator running until the user decides to exit
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("=== C# Simple Calculator ===");

                // Read first number
                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid number format. Press any key to try again.");
                    Console.ReadKey();
                    continue;
                }

                // Read operator
                Console.Write("Enter an operator (+, -, *, /): ");
                string op = Console.ReadLine();

                // Read second number
                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid number format. Press any key to try again.");
                    Console.ReadKey();
                    continue;
                }

                double result = 0;
                bool validOperation = true;

                // Perform calculation using a switch statement
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                            validOperation = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operator.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
                }

                // Ask to continue
                Console.Write("\nDo you want to perform another calculation? (y/n): ");
                string answer = Console.ReadLine()?.Trim().ToLower();
                if (answer != "y")
                {
                    keepRunning = false;
                }
            }
        }
    }
}
