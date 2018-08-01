using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StringCalculator
    {
        public static List<char> delimiters = new List<char> { ',', '\n' };
        public static string errorMessage = "Don't use negative numbers {0}";

        public static int AddNumber(string number)
        {
            var singleNumber = int.Parse(number);

            if(singleNumber < 0)
            {
                throw new Exception(string.Format(errorMessage, singleNumber));
            }

            if(singleNumber > 1000)
            {
                return 0;
            }

            return singleNumber;
        }

        public static int AddNumbers(string numbers)
        {
            if(numbers.StartsWith("//"))
            {
                delimiters.Add(numbers[2]);
                numbers = numbers.Substring(4); 
            }

            var result = 0;
            bool hasNegativeNumber = false;

            foreach(var stringNumber in numbers.Split(delimiters.ToArray()))
            {
                var integerNumber = int.Parse(stringNumber);

                if (integerNumber < 0)
                    hasNegativeNumber = true;
                if(integerNumber < 1001)
                    result += integerNumber;
            }

            if(hasNegativeNumber == true)
            {
                throw new Exception(string.Format(errorMessage, 
                    string.Join(",", numbers.Split(delimiters.ToArray())
                    .Where(n=>int.Parse(n) < 0)
                    )));
            }

            return result;
        }

        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            if (delimiters.Any(n => numbers.Contains(n)) || numbers.StartsWith("//"))
                return AddNumbers(numbers);

            return AddNumber(numbers);
        }

        
    }
}
