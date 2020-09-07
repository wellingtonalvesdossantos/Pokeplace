using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokeplace.Core.ExtensionMethods
{
    public static class EnumerableExtensions
    {
        public static bool HasResults<T>(this IEnumerable<T> list)
        {
            return list != null && list.Any();
        }
    }
}
