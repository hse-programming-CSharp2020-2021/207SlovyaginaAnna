using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    class SaleFactory : IEntityFactory<Sale>
    {
        private static long _id = 1;

        private long _buyerId;
        private long _shopId;
        private long _goodId;
        private int _quantity;
        private double _price;
        public SaleFactory(long buyerId, long shopId, long goodId, int quantity, double price)
        {
            _buyerId = buyerId;
            _shopId = shopId;
            _goodId = goodId;
            _quantity = quantity;
            _price = price;
        }
        public Sale Instance => new Sale(_id++, _buyerId, _shopId, _goodId, _quantity, _price);
    }
}
