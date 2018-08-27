using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStringExtensions
{
    public static class Extensions
    {
        public static bool? TryToBool(this string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				return null;
			}

			bool b;
			if (bool.TryParse(str, out b))
			{
				return b;
			}

			return null;
		}

		public static bool ToBool(this string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				return false;
			}

			bool b;
			return bool.TryParse(str, out b) && b;
		}

		public static bool IsAny(this string str)
		{
			return !string.IsNullOrEmpty(str);
		}

		public static bool HasAny(this string str)
		{
			return IsAny(str);
		}

		public static bool HasNoChar(this string str)
		{
			return string.IsNullOrWhiteSpace(str);
		}
		public static bool HasChar(this string str)
		{
			return !HasNoChar(str);
		}
		public static bool IsNullOrEmpty(this string str)
		{
			return string.IsNullOrEmpty(str);
		}

		public static int ToInt(this string str)
		{
			int i;
			return int.TryParse(str, out i) ? i : 0;
		}

		public static int TryToInt(this string str, int defaultValue)
		{
			int i;
			return int.TryParse(str, out i) ? i : defaultValue;
		}

		public static string Restrict(this string str, int len)
		{
			if (string.IsNullOrEmpty(str))
			{
				return string.Empty;
			}
			if (len >= str.Length)
			{
				return str;
			}
			if (len <= 0)
			{
				return string.Empty;
			}

			return str.Substring(0, len);
		}

		public static bool DoContains(this string str, string input)
		{
			return str != null && str.Contains(input);
		}

		public static string TrimEnd(this string str, string item)
		{
			if (string.IsNullOrEmpty(str)) return str;
			if (string.IsNullOrEmpty(item)) return str;
			if (str.EndsWith(item)) return str.Substring(0, str.LastIndexOf(item));
			return str;
		}

        /// <summary>
        /// Returns string as a byte array using the specified encoding
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
	    public static byte[] ToByteArray(this string str, Encoding encoding)
	    {
	        return encoding.GetBytes(str);
	    }

		public static string[] Split(this string str, string separator) =>
			str.Split(new[] { separator }, StringSplitOptions.None);

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
