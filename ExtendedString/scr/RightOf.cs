namespace ExtendedString;

public static partial class ExtendedString
{
    public static string RightOf(this string str, char character, int occurrenceIndex)
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
        
        return str.Substring(characterIndex + 1, str.Length - characterIndex - 1);
    }
}