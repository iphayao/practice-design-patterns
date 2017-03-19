using System;
using System.Collections.Generic;

namespace Flyweight
{
    class KarakTea
    {

    }
    class TeaMaker
    {
        protected Dictionary<string, KarakTea> availableTea = new Dictionary<string, KarakTea>();
        public KarakTea make(string preference)
        {
            if(!this.availableTea.ContainsKey(preference))
            {
                this.availableTea[preference] = new KarakTea();
            }
            return this.availableTea[preference];
        }
    }

    class TeaShop
    {
        protected Dictionary<int, KarakTea> orders = new Dictionary<int, KarakTea>();
        protected TeaMaker teaMaker;

        public TeaShop(TeaMaker teaMaker)
        {
            this.teaMaker = teaMaker;
        }

        public void TakeOrder(string teaType, int table) 
        {
            this.orders[table] = this.teaMaker.make(teaType);
        }
        public void serve()
        {
            foreach(KeyValuePair<int, KarakTea> tea in this.orders)
            {
                Console.WriteLine("Serving data to table# " + tea.Key.ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TeaMaker teaMaker = new TeaMaker();
            TeaShop shop = new TeaShop(teaMaker);

            shop.TakeOrder("less sugar", 1);
            shop.TakeOrder("more milk", 2);
            shop.TakeOrder("without sugar", 5);

            shop.serve();
        }
    }
}
