using System;
using System.Linq;

namespace ConsoleHelper_50
{
    public class Helper_50
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void Help()
        {
            Console.WriteLine("I helping you");
        }
        public static void Write(string s)
        {
            Console.Write(s);
        }
        public static void Write(string s, ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.Write(s);
            Console.ResetColor();
        }
        public static void WriteLn(string s)
        {
            Console.WriteLine(s);
        }
        public static void WriteLn(string s, bool prompt)
        {
            WriteLn(s);
            if (prompt)
            {
                Console.Write(">> ");
            }
        }
        public static void WriteLn(string s, ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            WriteLn(s);
            Console.ResetColor();
        }

        public static string? ReadLn()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string s = Console.ReadLine();
            Console.ResetColor();
            return s;
        }
        public static void TryFillYesOrNo(string question, out bool value)
        {
            var positiveReplies = new string[] { "yes", "да", "true" };
            var negativeReplies = new string[] { "no", "нет", "false" };
            value = false;
            bool isCorrect;
            do
            {
                isCorrect = false;
                WriteLn(question, true);
                string answer = ReadLn().ToLower();

                if (positiveReplies.Contains(answer))
                {
                    isCorrect = true;
                    value = true;
                }
                else if (negativeReplies.Contains(answer))
                {
                    isCorrect = true;
                    value = false;
                }
                else
                    WriteLn("Incorrect value!", ConsoleColor.Red);
            } while (!isCorrect);
        }
        public static void TryFillBool(string s, out bool value)
        {
            bool result;
            do
            {  
                WriteLn(s, true);
                result = bool.TryParse(ReadLn(), out value);
                if (!result)
                    WriteLn("Incorrect value!", ConsoleColor.Red);
            } while (!result);
        }
        public static void TryFillInt(string s, out int value, int minValue = int.MinValue)
        {
            bool result;
            do
            {
                WriteLn(s, true);
                result = Int32.TryParse(ReadLn(), out value) && (value > minValue);
                if (!result)
                     WriteLn("Incorrect value!", ConsoleColor.Red);
            } while (!result);
        }
        public static void TryFillByte(string s, out byte value, byte minValue = byte.MinValue)
        {
            bool result;
            do
            {
                WriteLn(s, true);
                result = byte.TryParse(ReadLn(), out value) && (value > minValue);
                if (!result)
                    WriteLn("Incorrect value!", ConsoleColor.Red);
            } while (!result);
        }
        public static void TryFillDouble(string s, out double value, double minValue = double.MinValue)
        {
            bool result;
            do
            {
                WriteLn(s, true);
                result = double.TryParse(ReadLn(), out value);
                if (!result)
                    WriteLn("Incorrect value!", ConsoleColor.Red);
            } while (!result);
        }
    }
}
