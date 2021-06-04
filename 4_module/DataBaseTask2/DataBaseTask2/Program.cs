using System;
using System.Linq;

namespace DataBaseTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase("ShopDataBase");

            db.CreateTable<Good>();
            db.CreateTable<Shop>();
            db.CreateTable<Buyer>();
            db.CreateTable<Sale>();

            db.InsertInto<Shop>(new ShopFactory("Auchan", "Samara", "15", "Russia", "88005553535"));
            db.InsertInto<Shop>(new ShopFactory("Magnit", "Moscow", "Odintsovo", "Russia", "89123456789"));

            db.InsertInto<Good>(new GoodFactory("Pepsi", 1, "Pshhh", "Drink"));
            db.InsertInto(new GoodFactory("3 korochki", 1, "Hrum", "Snacks"));
            db.InsertInto(new GoodFactory("Ohota", 2, "Beer","Drink"));
            db.InsertInto(new GoodFactory("Lays", 3,"90%-air","Snacks"));

            db.InsertInto(new BuyerFactory("John", "Snow", "The wall", "Winterfell", "Northen district", "Seven Kingdoms", "4567raven"));
            db.InsertInto(new BuyerFactory("Garfield", "TheCat", "711 Maple Street", "London", "cat district", "England", "711"));

            db.InsertInto(new SaleFactory(2, 2, 2, 3, 557));
            db.InsertInto(new SaleFactory(1, 1, 1, 1, 447));

            var auchanId = (from shop in db.Table<Shop>()
                            where shop.Name == "Auchan"
                            select shop.Id).First();

            var allAuchanGoods = from good in db.Table<Good>()
                                 where good.ShopId == auchanId
                                 select good.Name;
            // Товары покупателя с самым длинным именем
            var buyer = db.Table<Buyer>().OrderByDescending(x => x.Name.Length).First();
            var goodsNumbers = db.Table<Sale>().Where(x => x.BuyerId == buyer.Id).Select(x => x.GoodId).ToList();
            var goods = db.Table<Good>().Where(x => goodsNumbers.Contains(x.Id));
            foreach(var good in goods)
            {
                Console.WriteLine(good.Name);
            }
            Console.WriteLine();
            // Категория самого дорогого товара
            var idOfGood = db.Table<Sale>().OrderByDescending(x => x.Price).First();
            Console.WriteLine(db.Table<Good>().Where(x => x.Id == idOfGood.Id).Select(x => x.Category).First());
            Console.WriteLine();
            // Город с наименьшей суммой продаж
            var min = db.Table<Sale>().GroupBy(x => db.Table<Shop>().Where(y => x.ShopId == y.Id).Select(y => y.City).First()).Select(x => x.Sum(y => y.Quantity * y.Price)).OrderBy(x=>x).First();
            var city = db.Table<Sale>().GroupBy(x => db.Table<Shop>().Where(y=>x.ShopId==y.Id).Select(y=>y.City).First()).Where(x=>x.Sum(y=>y.Quantity*y.Price)==min).Select(x=>x.Key).First();
            Console.WriteLine(city);
            Console.WriteLine();
            // Фамилии покупателей, купивших самый популярный товар
            var quantity = db.Table<Sale>().GroupBy(x => x.GoodId).Select(x => x.Sum(y => y.Quantity)).OrderByDescending(x => x).First();
            var goodId = db.Table<Sale>().GroupBy(x => x.GoodId).Where(x => x.Sum(y => y.Quantity) == quantity).Select(x=>x.Key).First();
            var saleList = db.Table<Sale>().Where(x => x.GoodId == goodId).Select(x => x.BuyerId).ToList();
            var lastNames = db.Table<Buyer>().Where(x => saleList.Contains(x.Id)).Select(x => x.LastName);
            foreach(var ln in lastNames)
            {
                Console.WriteLine(ln);
            }
            Console.WriteLine();
            // Найти количество магазинов в стране где их меньше всего
            var number = db.Table<Shop>().GroupBy(x => x.Country).Select(x => x.Count()).OrderBy(x => x).First();
            Console.WriteLine(number);
            Console.WriteLine();
            // Покупки сделанные не в своем городе
            var sales = db.Table<Sale>().Where(x => db.Table<Buyer>().Where(y => y.Id == x.BuyerId).Select(z => z.City) != db.Table<Shop>().Where(y => y.Id == x.ShopId).Select(z => z.City));
            foreach(var s in sales)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            // Общая сумма покупок
            var price = db.Table<Sale>().Sum(x => x.Quantity * x.Price);
            Console.WriteLine(price);
            Console.WriteLine();
            foreach (var goodName in allAuchanGoods)
            {
                Console.WriteLine(goodName);
            }

            Console.ReadKey();
            db.SaveDataBase<Good>();
            db.SaveDataBase<Shop>();
            db.SaveDataBase<Buyer>();
            db.SaveDataBase<Sale>();

            db.Deserialize<Good>();
            db.Deserialize<Shop>();
            db.Deserialize<Buyer>();
            db.Deserialize<Sale>();
        }
    }
}