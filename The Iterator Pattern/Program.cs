using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Iterator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            Console.WriteLine("Print items using built-in iterator");

            IEnumerator<int> enumerator = nums.GetEnumerator();

            while(enumerator.MoveNext())
            {
                int item = enumerator.Current;
                Console.WriteLine(item);
            }
        }
    }
}
