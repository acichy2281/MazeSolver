using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_2
{
    class Factorial
    {
        public int Solve(int number)
        {
            // Base Case
            if (number == 1)
            {
                return number;
            }

            // Recurse to solve the solution, if number is not the base case
            return number * Solve(number - 1);
        }
    }
}
