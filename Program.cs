// Main program class
using ExceptionHandlingExample;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Calculator and AgeValidator classes
        Calculator calculator = new Calculator();
        AgeValidator ageValidator = new AgeValidator();

        // Create and assign two float variables, with one set to zero.
        float num1 = 10.5f; // Dividend
        float num2 = 0f;     // Divisor initialized to zero to demonstrate exception handling
        float result = 0f;   // Variable to store the result of division

        // Initialize an int with a random range from 2 to 30.
        Random random = new Random();
        int age = random.Next(2, 30); // Generates a random age between 2 and 30

        try
        {
            // Attempt to divide num1 by num2, which is zero, and will throw an exception.
            result = calculator.Divide(num1, num2);
        }
        catch (DivideByZeroException ex)
        {
            // Catch the DivideByZeroException and display the error message.
            Console.WriteLine($"Error: {ex.Message}");

            // Prompt the user to enter a floating-point number other than zero.
            Console.WriteLine("Please enter a floating-point number other than zero:");

            try
            {
                // Read user input, convert it to float, and attempt the division again.
                string userInputStr = Console.ReadLine();
                float userInput;

                // Validate and parse user input
                if (!float.TryParse(userInputStr, out userInput))
                {
                    throw new FormatException("Invalid input. Please enter a valid floating-point number.");
                }

                // Attempt division with user-provided input
                result = calculator.Divide(num1, userInput);

                // Display the result of the division
                Console.WriteLine($"The result of dividing {num1} by {userInput} is {result}");
            }
            catch (Exception innerEx)
            {
                // Catch any exceptions that occur during user input or division and display the error message.
                Console.WriteLine($"Error: {innerEx.Message}");
            }
        }
        finally
        {
            // This block always executes, regardless of whether an exception was thrown.
            // Display the result (or default value if an exception occurred) to the console.
            Console.WriteLine($"Calculations completed, with result of {result}!");
        }

        // Attempt to check if the generated age allows for playing mature games.
        try
        {
            ageValidator.CheckAge(age);
        }
        catch (ArgumentException ex)
        {
            // Catch an ArgumentException if the age is less than 17, and display a custom error message.
            Console.WriteLine($"Custom Error: {ex.Message}");
        }
    }
}