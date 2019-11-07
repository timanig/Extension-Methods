using System;
namespace ExtensionMethods
{
    public static class StringExtenstions
    {
        
            public static bool IsTwoWords(this string s)
            {
            if (s.Contains(" "))
                return true;
               return false;
            }
        
    }
}
