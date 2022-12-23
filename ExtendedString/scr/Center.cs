using System.Text;

namespace ExtendedString;

public static partial class ExtendedString
{
    public static string Center(this string str, int width)
    {
        if (str.Length >= width)
            return str;
        
        int edgeSpace = (width - str.Length) / 2;
        string edgeString = new string(' ', edgeSpace);

        return edgeString + str + edgeString;
    }
}