using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    [DataContract]
    class Good : IEntity
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public long ShopId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Category { get; set; }

        public Good(long id, string name, long shopId)
        {
            Id = id;
            Name = name;
            ShopId = shopId;
        }
        public Good(long id, string name, long shopId, string description, string category)
        {
            Id = id;
            Name = name;
            ShopId = shopId;
            Description = description;
            Category = category;
        }
        public override string ToString()
        {
            return $"GOOD - {Name}";
        }
    }
}
