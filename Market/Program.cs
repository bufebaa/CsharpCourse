using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Company c1 = new Company("Laguna");
            HomeDelivery h1 = new HomeDelivery("Michigan", c1);
            //Console.WriteLine(h1.ToString());

            Ingridient tomato = new Ingridient("Помидор", 123);
            Ingridient cucumber = new Ingridient("Огурец", 123);
            Ingridient pepper = new Ingridient("Перец", 123);
            Ingridient lemon = new Ingridient("Лимон", 123); 
            Ingridient pasta = new Ingridient("Соус", 123);

            Product toamatoes = new Product("Жаренные пгомидоры в соусе", 200, tomato, pasta);
            Product lemonchello = new Product("Лимон с огурцом", 200, lemon, cucumber);

            Order<int, HomeDelivery> o1 = new Order<int, HomeDelivery>(789, h1, toamatoes, lemonchello);
            Console.WriteLine(o1.ToString());

            //Console.WriteLine(toamatoes.ToString());
        }
    }

    abstract class Delivery
    {
        protected string delivery_address;
        public Delivery(string adress)
        {
            delivery_address = adress;
        }

        public abstract string ToString();
    }

    class HomeDelivery : Delivery
    {
        protected Company name = null;
        public HomeDelivery(string adress, Company name) : base(adress)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Адресс доставщика: {delivery_address}\nВыполняется компанией: {this.name.Name_of_the_comp}";
        }
    }

    class PickPointDelivery : Delivery
    {
        protected Company name = null;
        public PickPointDelivery(string adress, Company name) : base(adress)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Адресс доставщика: {delivery_address}\nВыполняется компанией: {this.name.Name_of_the_comp}";
        }
    }

    class ShopDelivery : Delivery
    {
        protected Company name = null;
        public ShopDelivery(string adress, Company name) : base(adress)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"Адресс доставщика: {delivery_address}\nВыполняется компанией: {this.name.Name_of_the_comp}";
        }
    }

    class Ingridient
    {
        protected string IngridientName;
        protected decimal weight;

        public Ingridient(string name, decimal weight)
        {
            this.IngridientName = name;
            this.weight = weight;
        }

        public string ingridientName
        {
            get
            {
                return IngridientName;
            }
        }
        public override string ToString()
        {
            return $"Ingridient name: {IngridientName}\nWeight: {weight}";
        }
    }

    class Product
    {
        protected Ingridient[] consist_of = null;
        protected string product_name;
        protected float cost;
        public Product(string name,float cost, params Ingridient[] ingridients)
        {
            product_name = name;
            this.cost = cost;
            consist_of = new Ingridient[ingridients.Length];
            consist_of = ingridients;
        }

        public override string ToString()
        {
            string temp = "";
            for(int i = 0;i< consist_of.Length;i++)
            {
                temp += String.Join(" ", consist_of[i].ingridientName)+" ";
            }
            return $"Name: {product_name}\nIngridients: {temp}";
        }

        public float Cost
        {
            get
            {
                return cost;
            }
        }

        public string Product_name
        {
            get
            {
                return product_name;
            }
        }

    }

    class Client
    {
        protected string name;
        protected int bonuses;
        protected string client_adress;
        public Client(string name, int bonuses, string adress)
        {
            this.name = name;
            this.bonuses = bonuses;
            this.client_adress = adress;
        }
    }

    class Company
    {
        protected string name_of_the_comp;
        public Company(string name)
        {
            this.name_of_the_comp = name;
        }

        public Company()
        {
            this.name_of_the_comp = "Универсальная доставка";
        }

        public string Name_of_the_comp
        {
            get
            {
                return name_of_the_comp;
            }
        }
    }

    class Order<T,TDelivery> where TDelivery: Delivery
    {
        protected T number;
        protected Product[] cart;
        protected float total_sum = 0;
        public TDelivery Delivery;

        public Order(T number, TDelivery delivery,params Product[] cart)
        {
            this.number = number;
            this.cart = new Product[cart.Length];
            this.cart = cart;
            Delivery = delivery;
            getTotalSum();
        }

        private void getTotalSum()
        {
            for(int i=0; i<cart.Length; i++)
            {
                this.total_sum += cart[i].Cost;
            }
        }

        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < cart.Length; i++)
            {
                temp += String.Join(" ", cart[i].Product_name) + "\n";
            }
            return $"ID: {number.ToString()}\nCart: {temp}\nTotal sum: {total_sum}\nDelivery info: {Delivery.ToString()}";
        }
    }

}
