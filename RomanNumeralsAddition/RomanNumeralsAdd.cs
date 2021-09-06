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

        static void Main(string[] args)
        {
            var strRoman1 = "LX";
            var strRoman2 = "DCCL";

            int answer = ConvertRomanNumeralToNumber(strRoman1) + ConvertRomanNumeralToNumber(strRoman2);

            Console.WriteLine("The sum of Roman numerals (" + strRoman1 + ") and (" + strRoman2 + ") is : " + answer);
            Console.ReadLine();
        }
    }
}
