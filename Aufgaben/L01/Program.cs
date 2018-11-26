using System;
using System.Text;

namespace Softwaredesign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = Convert.ToInt32(args[0]);
                if (value >= 0 && value <= 999)
                {
                    Console.WriteLine(GetRomanNumber(value));
                }
                else 
                {
                    Console.WriteLine("Only numbers between 0 and 999");
                }
            }
            catch
            {
                Console.WriteLine("Wrong input only numbers");
            }
        }
        public static StringBuilder GetRomanNumber(int value)
        {
            StringBuilder sb = new StringBuilder();
            GetRomanNumberHundreds(value, sb);
            GetRomanNumberTens(value % 100, sb);
            GetRomanNumberOnes(value % 10, sb);
            return sb;
        }

        public static StringBuilder GetRomanNumberHundreds(int value, StringBuilder sb)
        {
            char firstDigit = value.ToString()[0];
            int valueFirstDigit = (int)char.GetNumericValue(firstDigit);

            if(100 < value && value < 400)
            {
                for (int i = 0; i < valueFirstDigit; i++)
                {
                    sb.Append("C");
                }
            }

            else if(400 <= value && value < 500)
            {
                sb.Append("CD");
            }

            else if(500 <= value && value < 600)
            {
                sb.Append("D");
            }

            else if(600 <= value && value < 900)
            {
                sb.Append("D");
                for (int i = 0; i < valueFirstDigit-5; i++)
                {
                    sb.Append("C");
                }
            }

            else if(900 <= value)
            {
                sb.Append("CM");
            }

            return sb;
        }

        public static StringBuilder GetRomanNumberTens(int value, StringBuilder sb)
        {

             char firstDigit = value.ToString()[0];
            int valueFirstDigit = (int)char.GetNumericValue(firstDigit);

            if(10 < value && value < 40)
            {
                for (int i = 0; i < valueFirstDigit; i++)
                {
                    sb.Append("X");
                }
            }
            else if(40 <= value && value < 50)
            {
                sb.Append("XL");
            }

            else if(50 <= value && value < 60)
            {
                sb.Append("L");
            }

            else if(60 <= value && value < 90)
            {
                sb.Append("L");
                for (int i = 0; i < valueFirstDigit-5; i++)
                {
                    sb.Append("X");
                }
            }

            else if(90 <= value)
            {
                sb.Append("XC");
            }

            return sb;
        }

        public static StringBuilder GetRomanNumberOnes(int value, StringBuilder sb)
        {
            char firstDigit = value.ToString()[0];
            int valueFirstDigit = (int)char.GetNumericValue(firstDigit);

            if(1 < value && value < 4)
            {
                for (int i = 0; i < valueFirstDigit; i++)
                {
                    sb.Append("I");
                }
            }

            else if(4 <= value && value < 5)
            {
                sb.Append("IV");
            }

            else if(5 <= value && value < 6)
            {
                sb.Append("V");
            }

            else if(6 <= value && value < 9)
            {
                sb.Append("V");
                for (int i = 0; i < valueFirstDigit-5; i++)
                {
                    sb.Append("I");
                }
            }

            else if(9 <= value)
            {
                sb.Append("IX");
            }

            return sb;
        }
    }
}