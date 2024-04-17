using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPExtensions
{
    public static class Extension
    {
        public static List<T> Filter<T>(this List<T> list, Func<T, bool> filter)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }


    }
}
