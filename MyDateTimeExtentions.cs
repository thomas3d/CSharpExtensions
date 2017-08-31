using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDateTimeExtensions
{
    public static class DateTimeExtentions
    {
        public static bool IsToday(this DateTime dateTime)
        {
            return (dateTime.Date == DateTime.Now.Date);
        }
    }
}
