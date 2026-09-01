public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = "";
        bool capitalizeNext = false;
        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                result += "CTRL";
            }
            else if (c == '-')
            {
                capitalizeNext = true;
            }
            else if (c == ' ')
            {
                result += '_';
            }
            else if (char.IsLetter(c) && !(c >= 'α' && c <= 'ω'))
            {
                if (capitalizeNext)
                {
                    result += char.ToUpper(c);
                    capitalizeNext = false;
                }
                else
                {
                    result += c;
                }
            }
        }    
        return result;
    }
}
