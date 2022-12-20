namespace ExtendedString;

public static partial class ExtendedString
{
    public static int CountOccurrence(this string str, string line)
    {
        return CountOccurrence(str, line, StringComparison.Ordinal);
    }
    
    public static int CountOccurrence(this string str, string line, StringComparison stringComparison)
    {
        if (String.IsNullOrEmpty(str))
            return 0;
        if (line == null)
            throw new ArgumentNullException(nameof(line));

        int stringIndex = str.IndexOf(line, stringComparison);
        
        int count = 0;

        while (stringIndex != -1)
        {
            count++;
            
            stringIndex = str.IndexOf(line, stringIndex + line.Length ,stringComparison);
        }

        return count;
    }
}