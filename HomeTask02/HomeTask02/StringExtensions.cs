public static class StringExtensions
{
    //public static string Reverse(this string input)
    //{
    //    char[] chars = input.ToCharArray();
    //    Array.Reverse(chars);
    //    return new string(chars);
    //}

    public static bool NullOrWhiteSpaceAndNumbers(this string word, bool ignoreCase)
    {
        if (ignoreCase)
        {
            foreach (var c in word)
            {
                if (c < '0' || c > '9')
                {
                    if (c == ',')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
            return true;

        }
        else
        {
            foreach (var c in word)
            {
                if (c < '0' || c > '9')
                    return false;

            }
            return true;
        }
    }
}