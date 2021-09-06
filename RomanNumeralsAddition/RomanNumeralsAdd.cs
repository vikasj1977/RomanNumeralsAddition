using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RomanNumeralsAddition
{
    class RomanNumeralsAdd
    {
        //Thought Process
        //add the Roman numerals with their corresponding values to a hash table
        //First pass the 2 roman numerals string to the function that would return the numeric value of each string
        //in the main method add the 2 numers that were returned by the function
        //write a function to convert the sum of 2 roman numerals to a roman numeral sum

        public static int ConvertRomanNumeralToNumber(string strRoman)
        {
            //used hash table to store the Roman letters and their corresponding values
            Hashtable hashRoman = new Hashtable();
            hashRoman.Add("I", 1);
            hashRoman.Add("V", 5);
            hashRoman.Add("X", 10);
            hashRoman.Add("L", 50);
            hashRoman.Add("C", 100);
            hashRoman.Add("D", 500);
            hashRoman.Add("M", 1000);

            var intSum1 = 0;

            for (var i = 0; i < strRoman.Length; i++)
            {
                if (hashRoman.ContainsKey(strRoman[i].ToString()))
                {
                    //1st condition checks if the current char is not the last char so that we dont get index out of range error 
                    //while checking the 2nd condition
                    //2nd condition is used to check if the next roman numeral is greater in value than the current roman numeral, 
                    //in that case we subtract the value of the current roman numeral from the next roman numeral
                    if (i < strRoman.Length - 1 && Convert.ToInt32(hashRoman[strRoman[i].ToString()]) < Convert.ToInt32(hashRoman[strRoman[i + 1].ToString()]))
                    {
                        intSum1 += Convert.ToInt32(hashRoman[strRoman[i + 1].ToString()]) - Convert.ToInt32(hashRoman[strRoman[i].ToString()]);
                        i = i + 1;
                    }
                    else
                    {
                        intSum1 += Convert.ToInt32(hashRoman[strRoman[i].ToString()]);
                    }
                }
            }

            return intSum1;
        }

        //function to convert the total sum to Roman Numerals sum
        public static string ConvertSumToRomanNumerals(Int32 intSum)
        {
            //stores possible Roman numeral combinations
            Hashtable hashPossibleValues = new Hashtable();
            hashPossibleValues.Add(1000, "M");
            hashPossibleValues.Add(900, "CM");
            hashPossibleValues.Add(500, "D");
            hashPossibleValues.Add(400, "CD");
            hashPossibleValues.Add(100, "C");
            hashPossibleValues.Add(90, "XC");
            hashPossibleValues.Add(50, "L");
            hashPossibleValues.Add(40, "XL");
            hashPossibleValues.Add(10, "X");
            hashPossibleValues.Add(9, "IX");
            hashPossibleValues.Add(5, "V");
            hashPossibleValues.Add(4, "IV");
            hashPossibleValues.Add(1, "I");

            var arr = new Int32[13] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var strRomanSum = "";

            for (var i = 0; i < arr.Length; i++)
            {
                while (arr[i] <= intSum)
                {
                    intSum = intSum - arr[i];
                    strRomanSum += hashPossibleValues[arr[i]].ToString();
                }
            }

            return strRomanSum;
        }

        public static bool IsRomanNumeralValid(string str)
        {
            //hashtable storing roman numerals and their corresponding values
            Hashtable hashRoman = new Hashtable();
            hashRoman.Add("I", 1);
            hashRoman.Add("V", 5);
            hashRoman.Add("X", 10);
            hashRoman.Add("L", 50);
            hashRoman.Add("C", 100);
            hashRoman.Add("D", 500);
            hashRoman.Add("M", 1000);

            //checking if input string is null (empty)
            if (str.Length == 0)
            {
                Console.WriteLine("Invalid input, one or both of the Roman numerals strings was empty.");
                Console.ReadLine();
                return false;
            }

            //checking if input string only contains Roman numeral characters
            foreach (char letter in str)
            {
                if (!hashRoman.Contains(letter.ToString()))
                {
                    Console.WriteLine("Invalid input, one or both of the string had an invalid Roman numeral.");
                    Console.ReadLine();
                    return false;
                }
            }

            //if string passes both the above tests, then string is valid and we can return true
            return true;

        }

        public static string Solution(string strRoman1, string strRoman2)
        {
            var sum = 0;
            var strRomanSum = "";

            //only if both strings are valid, continue with the program
            if (IsRomanNumeralValid(strRoman1) && IsRomanNumeralValid(strRoman2))
            {
                sum = ConvertRomanNumeralToNumber(strRoman1) + ConvertRomanNumeralToNumber(strRoman2);
                strRomanSum = ConvertSumToRomanNumerals(sum);
                return strRomanSum;
            }
            else
            {
                return "invalid";
            }
        }

        static void Main(string[] args)
        {
            var strRoman1 = "LX";
            var strRoman2 = "DCCL";

            var answer = Solution(strRoman1, strRoman2);

            if (answer != "invalid")
            {
                Console.WriteLine("The sum of Roman numerals (" + strRoman1 + ") and (" + strRoman2 + ") is : " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
