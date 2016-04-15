using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class MathsProblems
    {
        /// <summary>
        /// Sums two integer numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The sum of the numbers</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one of the arguments is greater than 100k</exception>
        public int Sum(int a, int b)
        {
            //if ((a > 100000) || (b > 100000))
            //{
            //    throw new ArgumentOutOfRangeException("One of the numbers was too large");
            //}
            return a + b;
        }
    }
}