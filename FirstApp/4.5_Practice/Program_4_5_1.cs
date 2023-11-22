using System;
using static ConsoleHelper_50.Helper_50;

namespace m4_5_Practice
{
    internal class Program_4_5_1
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, byte LoginLength, bool HasPet, string[] favcolors, double Age) User;
            WriteLn("Type your name:", true);
            User.Name = ReadLn();
            WriteLn("Type your last name:", true);
            User.LastName = ReadLn();
            WriteLn("Type your login:", true);
            User.Login = ReadLn();
            User.LoginLength = (byte)User.Login.Length;

            TryFillDouble("How old are you? (type a number)", out User.Age);

            TryFillBool("Do you have a pet? (type \"true\" or \"false\")", out User.HasPet);

            TryFillByte("How much favourite colors do you have?", out byte colorCount);
            User.favcolors = new string[colorCount];
            for (int i = 0; i < colorCount; i++)
            { 
                WriteLn("Type your favourite color:", true);
                User.favcolors[i] = ReadLn();
            }

            WriteLn("Form completed successfuly, congratulations! Thank you!", ConsoleColor.DarkGreen);
        }
    }
}
