namespace ExtendedString;

public static partial class ExtendedString
{
    /// <summary>
    /// Counts line occurrences in string
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="line">Line to count occurences of.</param>
    /// <returns>
    /// Returns an amount of line occurrences in a string.
    /// </returns>
    public static int CountOccurrence(this string str, string line)
    {
        return CountOccurrence(str, line, StringComparison.Ordinal);
    }
    
    /// <summary>
    /// Counts line occurrences in string
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="line">Line to count occurences of.</param>
    /// <param name="stringComparison">StringComparison to use to search for line.</param>
    /// <returns>
    /// Returns an amount of line occurrences in a string.
    /// </returns>
    public static int CountOccurrence(this string str, string line, StringComparison stringComparison)
    {
        if (String.IsNullOrEmpty(str))
            return 0;
        if (line == null)
            throw new ArgumentNullException(nameof(line));

        int stringIndex = str.IndexOf(line, stringComparison);
        
        int count = 0;

        while (stringIndex != -1)
        {
            count++;
            
            stringIndex = str.IndexOf(line, stringIndex + line.Length ,stringComparison);
        }

        return count;
    }
}