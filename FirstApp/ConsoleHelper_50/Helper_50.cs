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

        /// <summary>
        /// Просто метод для вывода на консоль с более коротким именем
        /// </summary>
        /// <param name="s"></param>
        public static void Write(string s)
        {
            Console.Write(s);
        }

        //public static void Write(string s, params object[] arg)
        //{
        //    Console.Write(s, arg);
        //}

        /// <summary>
        /// Тоже самое, но данная перегрузка принимает цвет текста и сбрасывает его после вывода
        /// </summary>
        /// <param name="s"></param>
        /// <param name="textColor"></param>
        public static void Write(string s, ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            Console.Write(s);
            Console.ResetColor();
        }

        /// <summary>
        /// Просто метод для вывода на консоль с более коротким именем
        /// </summary>
        /// <param name="s"></param>
        public static void WriteLn(string s)
        {
            Console.WriteLine(s);
        }

        /// <summary>
        /// Метод выводит текст в консоль и предлагает пользователю ввести данные в новой строке
        /// </summary>
        /// <param name="s"></param>
        public static void WriteLn(string s, bool prompt)
        {
            WriteLn(s);
            if (prompt)
            {
                Console.Write(">> ");
            }
        }

        /// <summary>
        /// Вывод в консоль, но данная перегрузка принимает цвет текста и сбрасывает его после вывода
        /// </summary>
        /// <param name="s"></param>
        /// <param name="textColor"></param>
        public static void WriteLn(string s, ConsoleColor textColor)
        {
            Console.ForegroundColor = textColor;
            WriteLn(s);
            Console.ResetColor();
        }

        /// <summary>
        /// Чтение строки из консоли
        /// </summary>
        /// <returns></returns>
        public static string? ReadLn()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string s = Console.ReadLine();
            Console.ResetColor();
            return s;
        }

        /// <summary>
        /// Метод задает пользователю вопрос и распознает ответ да/нет
        /// </summary>
        /// <param name="question"></param>
        /// <param name="value"></param>
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
