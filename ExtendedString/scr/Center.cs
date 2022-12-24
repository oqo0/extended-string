using System.Text;

namespace ExtendedString;

public static partial class ExtendedString
{
    /// <summary>
    /// Centers a string.
    /// </summary>
    /// <param name="str">Input string.</param>
    /// <param name="width">Maximal width of a field</param>
    /// <returns>
    /// Returns the string centered in a string of specified width.
    /// </returns>
    public static string Center(this string str, int width)
    {
        if (str.Length >= width)
            return str;
        
        int edgeSpace = (width - str.Length) / 2;
        string edgeString = new string(' ', edgeSpace);

        return edgeString + str + edgeString;
    }
}