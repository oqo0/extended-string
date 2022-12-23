namespace ExtendedString;

public static partial class ExtendedString
{
    public static string ReplaceAmount(this string str, string value, int amount)
    {
        return ReplaceAmount(str, value, amount, StringComparison.Ordinal);
    }
    public static string ReplaceAmount(this string str, string value, int amount, StringComparison stringComparison)
    {
        if (String.IsNullOrEmpty(str))
            return String.Empty;
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(value));
        if (value == null)
            throw new ArgumentNullException(nameof(value));
        
        int replaceCount = 0;

        while (replaceCount < amount)
        {
            str = RemoveFirstOccurrence(str, value, stringComparison);
            replaceCount++;
        }

        return str;
    }

    private static string RemoveFirstOccurrence(string str, string value, StringComparison stringComparison)
    {
        int valueIndex = str.IndexOf(value, stringComparison);
        
        if (valueIndex == -1)
        {
            return str;
        }
        
        return str.Substring(0, valueIndex) +
               str.Substring(valueIndex + value.Length, str.Length - (valueIndex + value.Length));
    }
}