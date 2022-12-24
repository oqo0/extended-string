namespace ExtendedString;

public static partial class ExtendedString
{
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