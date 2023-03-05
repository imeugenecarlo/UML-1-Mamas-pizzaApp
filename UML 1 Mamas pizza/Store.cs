using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_Mamas_pizza
{
    public class Store
    {
        public void Start()
        {
            Pizza p1 = new Pizza("Margherita", "Tomatsauce og mozzarella", 86);
            Pizza p2 = new Pizza("Bolognese", "Tomatsauce, mozzarella, skinke og kødsovs", 109);
            Pizza p3 = new Pizza("Ali's", "Tomatsauce, mozzarella, kebab, kødsovs, pepperoni, salat og dressing", 115);

            Drink d1 = new Drink("Coca-cola","33ml dåse",15);
            Drink d2 = new Drink("Rødvin","12% 0,75 l",123);
            Drink d3 = new Drink("Uludag Gazoz","33ml dåse",15);

            Customer c1 = new Customer("Karl Megs", "Cederlunden 31", "Karlmegs@yoyo.com", 12345678);
            Customer c2 = new Customer("Macayla Vind", "Rosehaven 12", "Macavinds@yeye.com", 09876543);
            Customer c3 = new Customer("Michael Fox", "Østerlund 2", "MLfox@roro.com", 87654321);

            Order o1 = new Order(p1, d1, c1);
            Order o2 = new Order(p2, d2, c2);
            Order o3 = new Order(p3, d3, c3);

            Console.WriteLine($"{o1}");
            Console.WriteLine($"Total price with tax and shipping is:{o1.CalculatéTotalPrice}kr");
            Console.WriteLine("   ");

            Console.WriteLine($"{o2}"); 
            Console.WriteLine($"Total price with tax and shipping is:{o2.CalculatéTotalPrice}kr");
            Console.WriteLine("   ");

            Console.WriteLine($"{o3}"); 
            Console.WriteLine($"Total price with tax and shipping is:{o3.CalculatéTotalPrice}kr");
        }
    }
}
