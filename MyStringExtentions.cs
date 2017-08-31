using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStringExtensions
{
    public static class Extensions
    {
        public static string StringBetween(this string s, string before, string after)
        {
            if (!s.Contains(before) || !s.Contains(after))
                return string.Empty;

            int pos1 = s.IndexOf(before) + before.Length;
            int pos2 = s.IndexOf(after, pos1);

            return s.Substring(pos1, pos2 - pos1);
        }

        public static string StringAfter(this string s, string substring)
        {
            if (!s.Contains(substring))
                return string.Empty;

            int pos1 = s.IndexOf(substring) + substring.Length;

            return s.Substring(pos1);
        }


        public static string Right(this string s, int len)
        {
            return s.Substring(s.Length - len);
        }

        public static string Left(this string s, int len)
        {
            return s.Substring(0, len);
        }
    }
}
