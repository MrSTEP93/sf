using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMiniMarket
{
    public abstract class Person
    {
        public string Name;
        public string Surname;
        public string PhoneNumber;
    }

    public class Employee : Person
    {
        public CompanyStore WorkPlace { get; private set; }
        public string Position { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime EmploymentDate { get; private set; }
        public Employee() : this("undef","undef") { }

        public Employee(string _name, string _surname) : this(_name, _surname, "undef") {  }

        public Employee(string _name, string _surname, string _phoneNumber) : this(_name, _surname, _phoneNumber, new DateTime(2000,01,01)) { }

        public Employee(string _name, string _surname, string _phoneNumber, DateTime _birthDate)
            : this(_name, _surname, _phoneNumber, _birthDate, "сотрудник") { }

        public Employee(string _name, string _surname, string _phoneNumber, DateTime _birthDate, string _position)
        {
            Name = _name;
            Surname = _surname;
            PhoneNumber = _phoneNumber;
            BirthDate = _birthDate;
            Position = _position;
            EmploymentDate = DateTime.Now;
            AllStaff.Add(this);
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
        public static void Add(Employee employee)
        {
            Staff.Add(employee);
            Count++;
        }
        public static List<Employee> GetAllStaff()
        {
            return Staff;
        }
    }

    public class Customer : Person
    {
        public string Rank;

    }
}
