using System;
using System.IO;
using System.Runtime.CompilerServices;
using static ConsoleHelper_50.Helper_50;

namespace BazarMiniMarket
{
    internal class Program
    {
        /// Вынес эту переменную в глобальную область, чтобы работать с ней в разных методах 
        /// Представим, что она есть в БД ))
        public static CompanyStore myStore;
        
        static void Main(string[] args)
        {
            WriteLn("Hello World!");

            Init();
            WriteLn("");
            var Staff = AllStaff.GetAllStaff();
            WriteLn("Personal data about every Employee (FROM STATIS CLASS 'AllStaff')", ConsoleColor.White);
            AllStaff.PrintAllStaff();

            WriteLn("");
            WriteLn("Lets add some staff and print all list again", ConsoleColor.White);
            ChangeInfo();
            AllStaff.PrintAllStaff();
        }

        private static void Init()
        {
            Employee Me = new Employee("Aleksey", "Shatalov", "8904", new DateTime(1993, 01, 07));
            myStore = new CompanyStore()
            {
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
                Director = Me,
                ShortName = "Head Office",
                PhoneNumber = Me.PhoneNumber,
                WorkSchedule = "Пн-Пт с 10 до 15"
            };

            WriteLn($"And now we have {CompanyStore.StoreCount} stores in out company.", ConsoleColor.Green);
            WriteLn($"It's address is {myStore.StoreAddress.ShortAddress}, Phone number is /{myStore.PhoneNumber}/");
            WriteLn($"Boss is: {myStore.Director.Name} {myStore.Director.Surname}, was born at {myStore.Director.BirthDate}. Tel: {myStore.Director.PhoneNumber}",ConsoleColor.White);

            WriteLn("");
            WriteLn("Lets buy new phone for working purposes");
            Me.PhoneNumber = "8915";
            WriteLn($"My new telephone number is /{Me.PhoneNumber}/ (FROM VARIABLE 'ME')");
            WriteLn($"New telephone number OF FIRST STORE is /{myStore.PhoneNumber}/ (FROM VARIABLE 'myStore', assignment through the boss (PhoneNumber = Director.PhoneNumber))");
            WriteLn("Not work... =(", ConsoleColor.Red);

            myStore.PhoneNumber = Me.PhoneNumber;
            WriteLn($"New telephone number OF FIRST STORE is /{myStore.PhoneNumber}/ (FROM VARIABLE 'myStore', direct assignment)");
            WriteLn("Ok, that is fine", ConsoleColor.Green);

            WriteLn("");
            WriteLn("Let's work hard, mafaka!!!!", ConsoleColor.Blue);
        }
        private static void ChangeInfo()
        {
            Employee Zam = new Employee("Elena", "Titova", "8800", new DateTime(1993, 02, 25));
            Employee anotherBoy = new Employee("Aleksey", "Merkulov", "8921", new DateTime(1975, 10, 17));

            /// В строке ниже получилось, что я через экземпляр класса Employee обратился к его индексатору, 
            /// который в свою очередь, обратился к статичному полю Staff статичного класса AllStaff, 
            /// представляющего собой список List<Employee>.  По-моему, это "per rectum".. )))
            /// В реальной задаче я бы постарался такого не избежать, но тут сделал, чисто ради науки))
            var boss = Zam["aleksey"];


        }
    }
}
