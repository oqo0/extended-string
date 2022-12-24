namespace ExtendedString;

public static partial class ExtendedString
{
    /// <summary>
    /// Exctacts the part of string at right from a character.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="character">Char to use to start a substring.</param>
    /// <returns>
    /// Returns a string to the right of a specified character.
    /// </returns>
    public static string RightOf(this string str, char character)
    {
        return RightOf(str, character, 0);
    }
    
    /// <summary>
    /// Exctacts the part of string at right from a character.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="character">Char to use to start a substring.</param>
    /// <param name="occurrenceIndex">Index of character occurrence which will be used as the start of the substring.</param>
    /// <returns>
    /// Returns a string to the right of a specified character.
    /// </returns>
    public static string RightOf(this string str, char character, int occurrenceIndex)
    {
        if (String.IsNullOrEmpty(str))
            return null;
        
        int characterIndex = str.IndexOf(character);
        if (characterIndex == -1 || characterIndex == str.Length - 1)
        {
            return null;
        }

        int occuranceCount = 0;
        
        while (occuranceCount < occurrenceIndex && characterIndex != -1)
        {
            characterIndex = str.IndexOf(character, characterIndex + 1);
            occuranceCount++;
        }
        
        return str.Substring(characterIndex + 1, str.Length - characterIndex - 1);
    }

    /// <summary>
    /// Exctacts the part of string at right from a string.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="value">String to use to start a substring.</param>
    /// <returns>
    /// Returns a string to the right of a specified string.
    /// </returns>
    public static string RightOf(this string str, string value)
    {
        return RightOf(str, value, 0);
    }
    
    /// <summary>
    /// Exctacts the part of string at right from a string.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="value">String to use to start a substring.</param>
    /// <param name="occurrenceIndex">Index of string occurrence end of which will be used as the start of the substring.</param>
    /// <returns>
    /// Returns a string to the right of a specified string.
    /// </returns>
    public static string RightOf(this string str, string value, int occurrenceIndex)
    {
        return RightOf(str, value, occurrenceIndex, StringComparison.Ordinal);
    }
    
    /// <summary>
    /// Exctacts the part of string at right from a string.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="value">String to use to start a substring.</param>
    /// <param name="occurrenceIndex">Index of string occurrence end of which will be used as the start of the substring.</param>
    /// <param name="stringComparison">StringComparison to use to search for value occurrence.</param>
    /// <returns>
    /// Returns a string to the right of a specified string.
    /// </returns>
    public static string RightOf(this string str, string value, int occurrenceIndex, StringComparison stringComparison)
    {
        if (String.IsNullOrEmpty(str))
            return null;
        
        int characterIndex = str.IndexOf(value, stringComparison);
        if (characterIndex == -1 || characterIndex == str.Length - 1)
        {
            return null;
        }

        int occuranceCount = 0;
        
        while (occuranceCount < occurrenceIndex && characterIndex != -1)
        {
            characterIndex = str.IndexOf(value, characterIndex + 1, stringComparison);
            occuranceCount++;
        }
        
        return str.Substring(
            characterIndex + value.Length,
            str.Length - characterIndex  - value.Length
            );
    }
}