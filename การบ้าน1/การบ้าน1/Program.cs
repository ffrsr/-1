using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้าน1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tshirt> orderTShirt = new List<Tshirt>();

            User jame = new User("Jame Watson");

            Tshirt JameOrder1 = new Tshirt("L", "Red", 500f);
            Tshirt JameOrder2 = new Tshirt("M", "Black", 750f);
            Tshirt JameOrder3 = new Tshirt("S", "Blue", 625f);

            jame.addList(JameOrder1);
            jame.addList(JameOrder2);
            jame.addList(JameOrder3);
            
            jame.name = "jame watson";
            jame.email = "jame@gmail.com";
            Console.WriteLine(jame.name);
            Console.WriteLine(jame.email);
            
            Address jamewatsonHouse = new Address();
            jamewatsonHouse.street = "131/75,Phutthamonthon";
            jamewatsonHouse.city = "Nakhon Pathom";
            jamewatsonHouse.zipCode = "10180";
            Console.WriteLine(jamewatsonHouse.street);
            Console.WriteLine(jamewatsonHouse.city);
            Console.WriteLine(jamewatsonHouse.zipCode);

            jame.getTShirt();

            double TotalCost = 500 + 750 + 625;
            Console.WriteLine("Total cost : {0} Baht",TotalCost);
            
            Console.ReadLine();
        }

        class Tshirt
        {
            public string size;
            public string color;
            public float price;            

            public Tshirt (string valueSize,string valueColor,float valuePrice)
            {
                size = valueSize;
                color = valueColor;
                price = valuePrice;
                
            }
            
        }

        class User
        {
            public string name;
            public string email;

            private List<Tshirt> orderTShirt;
            
            public User (string valueName)
            {
                name = valueName;
                orderTShirt = new List<Tshirt>();
            }


            public void addList(Tshirt TShirt)
            {
                orderTShirt.Add(TShirt);
            }

            public void getTShirt()
            {
                foreach (Tshirt item in orderTShirt)
                {
                    Console.WriteLine(item.size);
                    Console.WriteLine(item.color);
                    Console.WriteLine(item.price);                    
                }
            }

        }

        class Address
        {
            public string street;
            public string city;
            public string zipCode;

        }

        class ShoppingCart
        {
            public string size;
            public string color;
            public float price;
            
            private List<Tshirt> orderTShirt;

            public ShoppingCart(string valueSize, string valueColor, float valuePrice)
            {
                size = valueSize;
                color = valueColor;
                price = valuePrice;

                orderTShirt = new List<Tshirt>();
            }
            
        }
    }
}
