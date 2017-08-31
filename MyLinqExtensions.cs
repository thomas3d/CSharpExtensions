using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLinqExtensions
{
    public static class Extensions
    {
        public static T As<T>(this object input) where T : class
        {
            return input as T;
        }        
 
        public static bool In<T>(this T self, IEnumerable<T> input)
        {
            return input.Contains(self);
        }

        public static bool In<T>(this T self, params T[] input)
        {
            return input.Contains(self);
        }              
    }
}
