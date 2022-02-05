using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_2
{
    class TowerOfHanoi
    {
        public void Solve()
        {
            Console.WriteLine("Enter the number of discs to use");
            Console.WriteLine("Less than 5 is good");

            string input = Console.ReadLine();
            int discNumber = Int32.Parse(input);

            move(discNumber, 'A', 'B', 'C');
        }

        private void move(int n, char src, char temp, char dest)
        {
            // Base Case
            if (n == 1)
            {
                Console.WriteLine(
                    "Move disc from tower {0} to tower {1}",
                    src,
                    dest
                );
            }
            else
            {
                // Make a recursive call to move n-1 discs from the source to the temporary peg
                move(n - 1, src, dest, temp);
                // Make a recursive call to move the 1 disc from the
                // src to the destination. This will cause the base case to activate
                move(1, src, temp, dest);
                // Make a recursive call to move n - 1 discs from the temp to the dest.
                move(n - 1, temp, src, dest);
            }
        }
    }
}
