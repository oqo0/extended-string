namespace ExtendedString;

public static partial class ExtendedString
{
    public static string LeftOf(this string str, char character)
    {
        return LeftOf(str, character, 0);
    }
    
    public static string LeftOf(this string str, char character, int occurrenceIndex)
    {
        if (String.IsNullOrEmpty(str))
            return null;
        
        int characterIndex = str.IndexOf(character);
        if (characterIndex == -1 || characterIndex == 0)
        {
            return null;
        }

        int occuranceCount = 0;
        
        while (occuranceCount < occurrenceIndex && characterIndex != -1)
        {
            characterIndex = str.IndexOf(character, characterIndex + 1);
            occuranceCount++;
        }
        
        return str.Substring(0, characterIndex - 1);
    }

    public static string LeftOf(this string str, string value)
    {
        return LeftOf(str, value, 0);
    }
    
    public static string LeftOf(this string str, string value, int occurrenceIndex)
    {
        return LeftOf(str, value, occurrenceIndex, StringComparison.Ordinal);
    }
    
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
        
        return str.Substring(0, characterIndex - 1);
    }
}