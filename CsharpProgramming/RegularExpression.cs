using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace CsharpProgramming
{
   public class RegularExpression
   {
        public string RegexRules = "^[0-9]*[a-zA-Z]{3,}[0-9a-zA-Z]*$";

        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }

        public static void ValidatePinCode()
        {
            string Pattern = "^[1-9]{1}[0-9]{5}$";
            string[] inputs = { "852113", "5678943", "34578", "098345", "756432", "674312", "897432","852507"};
            foreach(string input in inputs)
            {
                bool Result = Regex.IsMatch(input, Pattern);
                if (Result)
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                    Console.WriteLine("{0} is invalid", input);
            }
        }
        public static void ValidateMobileNumber()
        {
            string Pattern = "^[91]{2} [6-9][0-9]{9}$";
            string[] inputs = { "91 9965328323", "91 7684932134", "91 6735283978", "91 8976974326", "91 93481562860", "91 5643784532", "91 8783945790", "91 88905878435", "91 7436245897" };
            foreach (string input in inputs)
            {
                bool Result = Regex.IsMatch(input, Pattern);
                if (Result)
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                    Console.WriteLine("{0} is invalid", input);
            }
        }
        public static void ValidateSpecialCharPassword()
        {
            string Pattern = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9]){3,}$";
            //string Pattern = "^([A-Z 0-9]*[!@#$%^&*]{1}.{8,}$";

            string[] inputs = { "345E6$7a892", "9823s4*51", "A012346&7598", "88943267%%41", "9#876548EE723", "T879^0542345", "67435Sj2@3512", "9808#9432145" };

            foreach (string input in inputs)
            {
                bool result = Regex.IsMatch(input, Pattern);

                if (result)
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                    Console.WriteLine("{0} is invalid", input);
            }
        }
    }
}
