public static class StringExtentions
{
    public static string FirstUpper(this string str)
    {
        str = str.ToLower();
        return str.Substring(0, 1).ToUpper() + (str.Length > 1 ? str.Substring(1) : "");
    }
}