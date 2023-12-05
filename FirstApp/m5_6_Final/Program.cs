using System;
using static ConsoleHelper_50.Helper_50;


namespace m5_6_Final
{
    internal class Program
    {
        static (string Name, string LastName, byte Age, bool HasPet, byte PetsCount, string[] PetsNames, byte ColorCount, string[] FavColors) User;
        static void Main(string[] args)
        {
            GetInfo();
            WriteLn("Form completed successfuly, congratulations! Thank you!", ConsoleColor.DarkGreen);
            WriteLn("");
            WriteLn("Now we know, who you are!", ConsoleColor.Blue);
            PrintInfo();
        }

        static void GetInfo()
        {
            WriteLn("Type your name:", true);
            User.Name = ReadLn();
            WriteLn("Type your last name:", true);
            User.LastName = ReadLn();
            TryFillByte("How old are you? (type a number)", out User.Age);

            TryFillYesOrNo("Do you have any pets?",  out User.HasPet);
            if (User.HasPet)
            {
                TryFillByte("How many pets do you have?", out User.PetsCount);
                User.PetsNames = GetPets(User.PetsCount);
            }

            TryFillByte("How much favourite colors do you have?", out User.ColorCount);
            User.FavColors = GetColors(User.ColorCount);
        }
        private static void PrintInfo()
        {
            //WriteLn(string.Format("Your full name: {0,25}", User.Name + " " + User.LastName));
            Write($"You are: ");
            WriteLn($"{User.Name} {User.LastName} ({User.Age} years old) ", ConsoleColor.White);
            if (User.HasPet)
            {
                Write($"You have {User.PetsCount} pet");
                if (User.PetsCount == 1)
                    Write(", his name is ");
                else
                    Write("s, them names are: ");
                foreach (var name in User.PetsNames)
                    Write(name + " ", ConsoleColor.White);
                WriteLn("");
            }
            else
                WriteLn("You have no pets", ConsoleColor.DarkGray);
            Write($"You have {User.ColorCount} favourite colors, it is ");
            foreach (var color in User.FavColors)
                Write(color + " ", ConsoleColor.White);
            WriteLn("");
            WriteLn("End of the data", ConsoleColor.Blue);
        }

        static string[] GetColors(byte colorCount)
        {
            var colors = new string[colorCount];
            for (int i = 0; i < colorCount; i++)
            {
                WriteLn($"Type your {i+1} favourite color:", true);
                colors[i] = ReadLn();
            }
            return colors;
        }

        static string[] GetPets (byte count)
        {
            var pets = new string[count];
            for (byte i = 0; i < count; i++)
            {
                WriteLn($"Type your {i+1} pet's name", true);
                pets[i] = ReadLn();
            }
            return pets;
        }
    }
}
