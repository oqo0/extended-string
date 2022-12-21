using Microsoft.VisualBasic;

namespace ExtendedString;

public static partial class ExtendedString
{
    public static string RightOf(this string str, char character)
    {
        return RightOf(str, character, 0);
    }
    
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

    public static string RightOf(this string str, string value)
    {
        return RightOf(str, value, 0);
    }
    
    public static string RightOf(this string str, string value, int occurrenceIndex)
    {
        return RightOf(str, value, occurrenceIndex, StringComparison.Ordinal);
    }
    
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
        
        return str.Substring(characterIndex + 1, str.Length - characterIndex - 1);
    }
}