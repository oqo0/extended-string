namespace ExtendedString;

public static partial class ExtendedString
{
    /// <summary>
    /// Extracts all the parts of the string that is between the occurrences of characters.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="character">Character to use for substring scope.</param>
    /// <returns>
    /// A set of substrings starting from the first occurrence of the character to the second occurrence of the character.
    /// Returns null if string is null or empty.
    /// </returns>
    public static IEnumerable<String> BetweenAll(this string str, char character)
    {
        return BetweenAll(str, character, character);
    }
    
    /// <summary>
    /// Extracts all the parts of the string that is between the occurrences of characters.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="openCharacter">Character to use to open substring scope.</param>
    /// <param name="closeCharacter">Character to use to close substring scope.</param>
    /// <returns>
    /// A set of substrings starting from the openCharacter to the closeCharacter.
    /// Returns null if string is null or empty.
    /// </returns>
    public static IEnumerable<String> BetweenAll(this string str, char openCharacter, char closeCharacter)
    {
        if (String.IsNullOrEmpty(str))
            return null;

        int openCharacterEntryIndex = str.IndexOf(openCharacter);
        if (openCharacterEntryIndex == -1 || openCharacterEntryIndex == str.Length - 1)
        {
            return null;
        }

        int closeCharacterEntryIndex = str.IndexOf(closeCharacter, openCharacterEntryIndex + 1);
        if (closeCharacterEntryIndex == -1)
        {
            return null;
        }

        var result = new List<String>();
        
        while (openCharacterEntryIndex != -1 && closeCharacterEntryIndex != -1)
        {
            result.Add(str.Substring(
                openCharacterEntryIndex + 1,
                closeCharacterEntryIndex - openCharacterEntryIndex - 1
            ));
            
            openCharacterEntryIndex = str.IndexOf(openCharacter, openCharacterEntryIndex + 1);
            closeCharacterEntryIndex = str.IndexOf(closeCharacter, openCharacterEntryIndex + 1);
        }

        return result;
    }

    /// <summary>
    /// Extracts all the parts of the string that is between the first two occurrences of openString.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="openString">String to use for substring scope.</param>
    /// <returns>
    /// A set of substrings starting from the first occurrence of the openString to the second occurrence of the openString.
    /// Returns null if string is null or empty.
    /// </returns>
    public static IEnumerable<String> BetweenAll(this string str, string openString)
    {
        return BetweenAll(str, openString, openString, StringComparison.Ordinal);
    }   
    
    /// <summary>
    /// Extracts all the parts of the string that is between the first two occurrences of openString.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="openString">String to use for substring scope.</param>
    /// <param name="stringComparison">StringComparison to use to search for open string occurrence.</param>
    /// <returns>
    /// A set of substrings starting from the first occurrence of the openString to the second occurrence of the openString.
    /// Returns null if string is null or empty.
    /// </returns>
    public static IEnumerable<String> BetweenAll(this string str, string openString, StringComparison stringComparison)
    {
        return BetweenAll(str, openString, openString, stringComparison);
    }
    
    /// <summary>
    /// Extracts all the parts of the string that is between the first two occurrences of openString.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="openString">String to use to open substring scope.</param>
    /// <param name="closeString">String to use to close substring scope.</param>
    /// <param name="stringComparison">StringComparison to use to search for open string occurrence.</param>
    /// <returns>
    /// A set of substrings starting from the openString to the closeString.
    /// Returns null if string is null or empty.
    /// </returns>
    public static IEnumerable<String> BetweenAll(this string str, string openString, string closeString, StringComparison stringComparison)
    {
        if (String.IsNullOrEmpty(str))
            return null;
        if (openString == null)
            throw new ArgumentNullException(nameof(openString));
        if (closeString == null)
            throw new ArgumentNullException(nameof(closeString));

        int openStringEntryIndex = str.IndexOf(openString, stringComparison);
        if (openStringEntryIndex == -1 || openStringEntryIndex == str.Length - 1)
        {
            return null;
        }

        int closeStringEntryIndex = str.IndexOf(closeString, openStringEntryIndex + 1, stringComparison);
        if (closeStringEntryIndex == -1)
        {
            return null;
        }

        var result = new List<String>();
        
        while (openStringEntryIndex != -1 && closeStringEntryIndex != -1)
        {
            result.Add(str.Substring(
                openStringEntryIndex + 1,
                closeStringEntryIndex - openStringEntryIndex - 1
            ));
            
            openStringEntryIndex = str.IndexOf(openString, openStringEntryIndex + 1, stringComparison);
            closeStringEntryIndex = str.IndexOf(closeString, openStringEntryIndex + 1, stringComparison);
        }

        return result;
    }
}