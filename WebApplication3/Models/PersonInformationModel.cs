using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class PersonInformationModel
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public struct Address
        {
            public Address(string street,string home,string apartment)
            {
                Street = street;
                Home = home;
                Apartment = apartment;
            }

            public string Street { get; set; }
            public string Home { get; set; }
            public string Apartment { get; set; }

            public override string ToString() => $"({Street}, {Home}, {Apartment})";
        }

    }
}
