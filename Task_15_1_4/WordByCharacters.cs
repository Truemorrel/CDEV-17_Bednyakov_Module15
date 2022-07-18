using System.Collections.Generic;
using System.Linq;

namespace Task_15_1_4
{
    public static class CharactersExtension
    {
        public static IEnumerable<TSource> CoupledChars<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Intersect(second).ToArray();
        }
    }
}
