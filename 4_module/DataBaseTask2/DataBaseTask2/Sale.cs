using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    [DataContract]
    class Sale : IEntity
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long BuyerId { get; set; }
        [DataMember]
        public long ShopId { get; set; }
        [DataMember]
        public long GoodId { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public double Price { get; set; }
        public Sale(long id, long buyerId, long shopId, long goodId, int quantity, double price)
        {
            Id = id;
            BuyerId = buyerId;
            ShopId = shopId;
            GoodId = goodId;
            Quantity = quantity;
            Price = price;
        }
        public override string ToString()
        {
            return $"SALE - {Id}";
        }
    }
}
