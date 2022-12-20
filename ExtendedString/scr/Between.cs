namespace ExtendedString;

public static partial class ExtendedString
{
    public static string Between(this string str, char character)
    {
        return Between(str, character, character);
    }
    
    public static string Between(this string str, char openCharacter, char closeCharacter)
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
    
        return str.Substring(openCharacterEntryIndex + 1, closeCharacterEntryIndex - openCharacterEntryIndex - 1);
    }

    public static string Between(this string str, string openString)
    {
        return Between(str, openString, openString, StringComparison.Ordinal);
    }   
    
    public static string Between(this string str, string openString, StringComparison stringComparison)
    {
        return Between(str, openString, openString, stringComparison);
    }
    
    public static string Between(this string str, string openString, string closeString, StringComparison stringComparison)
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
    
        return str.Substring(
            openStringEntryIndex + openString.Length,
            closeStringEntryIndex - (openStringEntryIndex + openString.Length)
            );
    }
}