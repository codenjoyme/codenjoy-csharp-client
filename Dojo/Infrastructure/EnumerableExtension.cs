using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Infrastructure
{
    public static class EnumerableExtension
    {
        public static string ListAsString<T>(this IEnumerable<T> currentList)
        {
            return string.Join(",", currentList.ToArray());
        }
    }
}
