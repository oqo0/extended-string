namespace ExtendedString;

public static partial class ExtendedString
{
    public static string Reverse(this string str)
    {
        if (str == null)
            return null;
        if (str == String.Empty)
            return String.Empty;

        char[] stringChars = str.ToCharArray();
        Array.Reverse(stringChars);
        
        return new string(stringChars);
    }
}