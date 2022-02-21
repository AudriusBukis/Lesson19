using System;
using System.Linq;


namespace Lesson19.Models
{
    public static class StringExtention
    {
        public static bool StringHasSpaces(this string str)
        {
            return str.Any(Char.IsWhiteSpace);
        }
        public static string GenerateEmail(this string str, string fullName, int yearOfBirth, string domain)
        {
            return $"{fullName}{yearOfBirth}@{domain}";
        }
    }
}
