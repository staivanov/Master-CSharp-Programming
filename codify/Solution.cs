using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codify
{
    class Solution
    {
        public Solution()
        {

        }



        public string MySolution(int AA, int AB, int BB)
        {
            // Implement your solution here

            string aa = "AA",
                   ab = "AB",
                   bb = "BB";

            int firstSequence = AA == 0 ? AB : AA;
            int secondSequence = AB == 0 ? BB : AB;
            int lastSequence = BB == 0 ? AA : BB;

            if ((firstSequence + lastSequence) == 0)
            {
                string result = "";

                for (int i = 0; i < AB; i++)
                {
                    result += ab;
                }

                return result;
            }
            else if ((secondSequence + lastSequence) != 0)
            {
                return aa;
            }
            else if((AB + BB) == 0)
            {
                return aa;
            }



            return "";
        }
    }
}
