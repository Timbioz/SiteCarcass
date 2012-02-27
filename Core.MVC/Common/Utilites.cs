using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSite.Core
{
    public static class Utilites
    {
        public static T To<T>(this string text)
        {
            return (T)Convert.ChangeType(text, typeof(T));
        }
    }
}
