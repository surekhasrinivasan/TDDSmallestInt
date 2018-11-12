using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] input)
        {
            if(input.Length < 1)
            {
                throw new ArgumentException();
            }
            Array.Sort(input);
            return input[0];            
        }
    }
}
