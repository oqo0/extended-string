namespace ExtendedString;

public static partial class ExtendedString
{
    /// <summary>
    /// Exctacts the part of string left from a character.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="character">Char to use to end substring.</param>
    /// <returns>
    /// Returns a string to the left of a specified character.
    /// </returns>
    public static string LeftOf(this string str, char character)
    {
        return LeftOf(str, character, 0);
    }
    
    /// <summary>
    /// Exctacts the part of string left from a character.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="character">Char to use to end substring.</param>
    /// <param name="occurrenceIndex">Index of character occurrence which well be used as the end of the substring.</param>
    /// <returns>
    /// Returns a string to the left of a specified character.
    /// </returns>
    public static string LeftOf(this string str, char character, int occurrenceIndex)
    {
        if (String.IsNullOrEmpty(str))
            return null;
        
        int characterIndex = str.IndexOf(character);
        if (characterIndex == -1 || characterIndex == 0)
        {
            return null;
        }

        int occurrenceCount = 0;
        
        while (occurrenceCount < occurrenceIndex && characterIndex != -1)
        {
            characterIndex = str.IndexOf(character, characterIndex + 1);
            occurrenceCount++;
        }
        
        return str.Substring(0, characterIndex);
    }

    /// <summary>
    /// Exctacts the part of string left from a string.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="value">String to use to end substring.</param>
    /// <returns>
    /// Returns a string to the left of a specified string.
    /// </returns>
    public static string LeftOf(this string str, string value)
    {
        return LeftOf(str, value, 0);
    }
    
    /// <summary>
    /// Exctacts the part of string left from a string.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="value">String to use to end substring.</param>
    /// <param name="occurrenceIndex">Index of stringoccurrence which well be used as the end of the substring.</param>
    /// <returns>
    /// Returns a string to the left of a specified string.
    /// </returns>
    public static string LeftOf(this string str, string value, int occurrenceIndex)
    {
        return LeftOf(str, value, occurrenceIndex, StringComparison.Ordinal);
    }

    /// <summary>
    /// Exctacts the part of string left from a string.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="value">String to use to end substring.</param>
    /// <param name="occurrenceIndex">Index of string occurrence which well be used as the end of the substring.</param>
    /// <param name="stringComparison">StringComparison to use to search for value occurrence.</param>
    /// <returns>
    /// Returns a string to the left of a specified string.
    /// </returns>
    public static string LeftOf(this string str, string value, int occurrenceIndex, StringComparison stringComparison)
    {
        if (String.IsNullOrEmpty(str))
            return null;
        
        int characterIndex = str.IndexOf(value, stringComparison);
        if (characterIndex == -1 || characterIndex == 0)
        {
            return null;
        }

        int occurrenceCount = 0;
        
        while (occurrenceCount < occurrenceIndex && characterIndex != -1)
        {
            characterIndex = str.IndexOf(value, characterIndex + 1, stringComparison);
            occurrenceCount++;
        }
        
        return str.Substring(0, characterIndex);
    }
}