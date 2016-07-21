using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberTranslator
{
    public static class RomanNumberTranslator
    {
        private static readonly Dictionary<int, string> Maping = null;

        static RomanNumberTranslator()
        {
            Maping = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };
        }

        /// <summary>
        /// Pass integer number
        /// </summary>
        /// <param name="intNumber">integer arabic decimal number to be converted to Roman number</param>
        public static string To(int intNumber)
        {

        }

    }
}
