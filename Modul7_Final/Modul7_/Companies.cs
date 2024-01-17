using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMiniMarket
{
    public class Address
    {
        public string Region;
        public string City;
        public uint PostCode;
        public string Street;
        public uint Number;
        public uint? AddNumber;
        public string Building;
        public byte Floor;
        public uint Office;
        public string ShortAddress { 
            get 
            {
                return String.Format("{0}, {1} {2}", this.Street, this.Number, this.AddNumber == 0 ? "" : this.AddNumber);
            } 
        }
        public string Description;
    }
    
    public abstract class AnyCompany
    {
        public Address StoreAddress;
        public string WorkSchedule;
        public string PhoneNumber;
    }

    public class CompanyStore : AnyCompany
    {
        public string ShortName;
        public decimal Rating;
        public Employee Director;
        public Employee[] Staff;
        public static byte StoreCount { get; private set; }
        public CompanyStore()
        {
            StoreCount++;
        }
    }

}
