using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    [Serializable]
    public class Product
    {
        protected int _price;

        //public Product(int price)
        //{
        //    _price = price;
        //}

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("----Информация о товаре----");
            Console.WriteLine($"Цена: {_price} руб.");
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }

    [Serializable]
    public class Pastry : Product
    {
        [NonSerialized]
        protected int _weight;
        protected string _factory;

        //public Pastry(int price, int weight, string factory) : base(price)
        //{
        //    _weight = weight;
        //    _factory = factory;
        //}

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }
    }
}
