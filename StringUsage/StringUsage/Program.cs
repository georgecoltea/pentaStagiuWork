using System;

namespace StringUsage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string example = "I will use this string for examples";

            //First method Concat

            string toConcatenate = "Concatenate it";
            Console.WriteLine(string.Concat(example, " ", toConcatenate));

            //Second method

            string upper = example.ToUpper();
            Console.WriteLine(upper);

            //Third method

            string lower = example.ToLower();
            Console.WriteLine(lower);

            //4th method

            Console.WriteLine(example.GetHashCode());

            //5th method

            Console.WriteLine(example.LastIndexOf('a'));

            //6th method

            Console.WriteLine(example.Replace('a', 'x'));

            //7th method

            string trimExample = "     whitespaces before and after     ";
            Console.WriteLine(trimExample.Trim());

          
        }
    }
}
