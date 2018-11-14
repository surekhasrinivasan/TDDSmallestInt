using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] input)
        {
            if (input.Length == 0)
            {
                throw new ArgumentException();
            }
            Array.Sort(input);
            return input[0];
        }

        public int FindClosestIntToZero(int[] input)
        {
            int num = int.MaxValue;

            if (input.Length == 0)
            {
                throw new ArgumentException();
            }

            foreach (int i in input)
            {

                if (Math.Abs(i) < Math.Abs(num))
                {
                    num = i;
                }

                if ((Math.Abs(i) == Math.Abs(num)) && (i < num))
                {
                    num = i;
                }                
            }
            return num;
        }
    }
}
