// Initialize a random number generator
Random random = new Random();

// Method to generate a random number within a specified range
public int GenerateRandomNumber(int min, int max)
{
    // Ensure the range is valid
    if (min > max)
    {
        throw new ArgumentOutOfRangeException("min", "min should not be greater than max.");
    }

    // Return a random number within the range [min, max]
    // The upper bound of the Next method is exclusive, hence 'max + 1' ensures 'max' is inclusive
    return random.Next(min, max + 1);
}
