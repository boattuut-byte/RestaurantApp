using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SIT.1/1");
            Console.WriteLine("Week 2");

            //create list
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1,"Quanjude Roast duck","Beijing Cuisine",4.5),
                new Restaurant(2,"Donglaishun Hot Pot","Hot Pot",4.6),
                new Restaurant(3,"Din Tai")
            };
        }
    }
}
public class Restaurant
{ 
}
