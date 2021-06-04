using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataBaseTask2
{
    [DataContract]
    class Buyer : IEntity
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string District { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Postcode { get; set; }

        public Buyer(long id, string name,string lastName,string adress, string city, string district, string country, string postcode)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Adress = adress;
            District = district;
            City = city;
            Country = country;
            Postcode = postcode;
        }
        public override string ToString()
        {
            return $"BUYER - {Name}";
        }
    }
}
