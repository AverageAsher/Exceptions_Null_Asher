// Class responsible for age validation
class AgeValidator
{
    /// <summary>
    /// Checks if the provided age is sufficient for playing mature games.
    /// Throws ArgumentException if age is less than 17.
    /// </summary>
    /// <param name="age">Age to validate</param>
    public void CheckAge(int age)
    {
        if (age >= 17)
        {
            // Inform the user that they can play mature games
            Console.WriteLine($"You are {age}, you can play mature games!");
        }
        else
        {
            // Throw an exception if the user is too young
            throw new ArgumentException("You are too young to play mature games.");
        }
    }
}