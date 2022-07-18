using System.Collections.Generic;
using System.Linq;

namespace Task_15_1_4
{
    public static class CharactersExtension
    {
        public static char[] CoupledChars(this string first, string second)
        {
            IEnumerable<char> charsFirst = first.ToCharArray();
            char[] charsSecond = second.ToCharArray();
            var result = charsFirst.Intersect(charsSecond);

            return result.ToArray();
        }
    }
}
