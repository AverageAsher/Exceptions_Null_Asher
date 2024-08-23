namespace ExceptionHandlingExample
{
    // Class responsible for division operations
    class Calculator
    {
        /// <summary>
        /// Divides two floating-point numbers.
        /// Throws DivideByZeroException if the divisor is zero.
        /// </summary>
        /// <param name="a">Dividend</param>
        /// <param name="b">Divisor</param>
        /// <returns>Result of division</returns>
        public float Divide(float a, float b)
        {
            if (b == 0)
            {
                // Throw an exception if division by zero is attempted
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            // Perform division and return the result
            return a / b;
        }
    }
}
