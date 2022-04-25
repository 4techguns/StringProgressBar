using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgressBar
{
    public static class RoundingExtensions
    {
        /// <summary>
        /// Round the integer to the nearest ten.
        /// </summary>
        /// <param name="i">The integer to round</param>
        /// <returns>The rounded integer</returns>
        public static int Round(this int i)
        {
            return ((int)Math.Round(i / 10.0)) * 10;
        }
    }
}
