using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    class BuyerFactory : IEntityFactory<Buyer>
    {
        private static long _id = 1;

        private string _name;
        private string _lastName;
        private string _adress;
        private string _city;
        private string _district;
        private string _country;
        private string _postecode;

        public BuyerFactory(string name,string lastName, string adress, string city, string district, string country, string postecode)
        {
            _name = name;
            _lastName = lastName;
            _adress = adress;
            _city = city;
            _district = district;
            _country = country;
            _postecode = postecode;
        }
        public Buyer Instance => new Buyer(_id++, _name, _lastName, _adress, _city, _district, _country, _postecode);
    }
}
