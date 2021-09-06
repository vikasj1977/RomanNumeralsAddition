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

            return intSum1;
        }

        static void Main(string[] args)
        {
        }
    }
}
