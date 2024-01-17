using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMiniMarket
{
    public abstract class Person
    {
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public string PhoneNumber;
        public Person(string _name, string _surname)
        {
            Name = _name;
            Surname = _surname;
        }
    }

    public class Employee : Person
    {
        public CompanyStore WorkPlace { get; private set; }
        public string Position { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime EmploymentDate { get; private set; }

        public Employee(string _name, string _surname) : this(_name, _surname, "noNumber") {  }

        public Employee(string _name, string _surname, string _phoneNumber) : this(_name, _surname, _phoneNumber, new DateTime(2000,01,01)) { }

        public Employee(string _name, string _surname, string _phoneNumber, DateTime _birthDate)
            : this(_name, _surname, _phoneNumber, _birthDate, "сотрудник") { }

        public Employee(string _name, string _surname, string _phoneNumber, DateTime _birthDate, string _position) : base(_name, _surname)
        {
            PhoneNumber = _phoneNumber;
            BirthDate = _birthDate;
            Position = _position;
            EmploymentDate = DateTime.Now;
            AllStaff.Add(this);
        }

        public Employee this[string _searchString]
        {
            get
            {
                foreach (var person in AllStaff.GetAllStaff())
                {
                    if ((person.Name.ToLower() == _searchString.ToLower()) || (person.Surname.ToLower() == _searchString.ToLower()))
                    {
                        return person;
                    }
                }
                return null;
            }
        }
        public Employee this[string _name, string _surname]
        {
            get
            {
                foreach (var person in AllStaff.GetAllStaff())
                {
                    if ((person.Name.ToLower() == _name.ToLower()) && (person.Surname.ToLower() == _surname.ToLower()))
                    {
                        return person;
                    }
                }
                return null;
            }
        }
        public List<Employee> this[DateTime _birthdate]
        {
            get
            {
                var result = new List<Employee>();
                foreach (var person in AllStaff.GetAllStaff())
                {
                    if (person.BirthDate == _birthdate)
                    {
                        result.Add(person);
                    }
                }
                return result;
            }
        }
    }

    public static class AllStaff
    {
        private static readonly List<Employee> Staff;
        public static uint Count { get; private set; }
        static AllStaff()
        {
            Staff = new();
        }

        public static void Add(Employee _employee)
        {
            Staff.Add(_employee);
            Count++;
        }
        public static List<Employee> GetAllStaff()
        {
            return Staff;
        }
        public static void PrintAllStaff()
        {
            foreach (var person in Staff)
            {
                Console.WriteLine($"{person.Name}, {person.Surname},  {person.Position},  {person.PhoneNumber},  {person.BirthDate}");
            }
        }
    }

    public class Customer : Person
    {
        public string Rank { get; private set; }
        public Customer(string _name, string _surname) : base(_name, _surname)
        {
            Rank = "Новичок";
        }
    }
}
