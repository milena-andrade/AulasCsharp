using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDois
{


    public static class StringUtils
    {
        public static string InverterString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool Palindromo(string input)
        {
            string reversed = InverterString(input);
            return input.Equals(reversed);
        }
    }

}
