using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    [DataContract]
    class Shop : IEntity
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string District { get; set; }
        [DataMember]
        public string Country{get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }

        public Shop(long id, string name)
        {
            Id = id;
            Name = name;
        }
        public Shop(long id, string name, string city, string district, string country, string phoneNumber)
        {
            Id = id;
            Name = name;
            District = district;
            City = city;
            Country = country;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"SHOP - {Name}";
        }
    }
}
