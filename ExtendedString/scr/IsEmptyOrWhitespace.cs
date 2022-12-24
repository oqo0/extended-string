namespace ExtendedString;

public static partial class ExtendedString
{
    /// <summary>
    /// Checks if string is empty or consists only of whitespaces.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <returns>
    /// Returns true if string is empty or consists only of whitespaces.
    /// False in another case.
    /// </returns>
    public static bool IsEmptyOrWhitespace(this string str)
    {
        if (String.IsNullOrWhiteSpace(str))
            return false;
        
        if (str.Length == 0 || IsEveryCharWhitespace(str))
            return true;
        
        return false;
    }

    private static bool IsEveryCharWhitespace(string str)
    {
        foreach (char c in str)
        {
            if (c != ' ')
                return false;
        }

        return true;
    }
}