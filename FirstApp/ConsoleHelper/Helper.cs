namespace ConsoleHelper
{
    public class Helper
    {
        static void Main(string[] args)
        {
        }
        public static void Help()
        {
            Console.WriteLine("I helping you");
        }
        public static void WriteLn (string s)
        {
            Console.WriteLine(s);
        }
        public static void WriteLn(string s, bool prompt)
        {
            Console.WriteLine(s);
            if (prompt)
            {
                Console.Write(">> ");
            }
        }
        //public static void ReadLn ()
        //{
        //    Console.ReadLine();
        //}
        public static string? ReadLn ()
        {
            string s = Console.ReadLine();
            return s;
        }
    }
}