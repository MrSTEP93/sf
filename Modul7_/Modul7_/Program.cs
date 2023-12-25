using System;
using static ConsoleHelper_50.Helper_50;

namespace BazarMiniMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLn("Hello World!");
            Init();
            WriteLn("");
            var Staff = AllStaff.GetAllStaff();
            foreach (var person in Staff)
            {
                WriteLn($"{person.Name}, {person.Surname}, {person.BirthDate},  {person.Position}");
            }

        }

        private static void Init()
        {
            Employee Iam = new Employee("Aleksey", "Shatalov", "8800", new DateTime(1993, 01, 07));
            CompanyStore myStore = new CompanyStore
            {
                Director = Iam,
                StoreAddress = new Address()
                {
                    Region = "Russia",
                    City = "Belgorod",
                    Street = "Esenina",
                    Number = 1,
                    AddNumber = 0,
                    PostCode = 308160,
                    Floor = 2,
                    Office = 223,
                    Building = string.Empty,
                    Description = "Head office of my amazing Company - \"Bazar Mini Market\""
                },
                ShortName = "Head Office",
                PhoneNumber = "",
                WorkSchedule = "Пн-Пт с 10 до 15"
            };
            WriteLn($"And now we have {CompanyStore.StoreCount} stores in out company. It's address is {myStore.StoreAddress.ShortAddress}", ConsoleColor.Green);
            WriteLn("Let's work hard, mafaka!!!!", ConsoleColor.DarkRed);
        }
    }
}
