using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2HW240323
{
    class Building
    {
        public string Name { get; set; }

        public List<Room> Rooms { get; set; }

        public Building (string name, List<Room> rooms)
        {
            Name = name;
            Rooms = rooms;
        }

		// Метод для расчета общей стоимости здания
		public double GetPrice()
        {
            double price = 0;
            foreach(Room room in Rooms) price += room.GetPrice();
            return price;
        }
    }


	public class Room
    {
        public string Name { get; set; }

        public List<Furniture> Furnitures { get; set; }

        public Room(List<Furniture> furnitures)
        {
            Furnitures = furnitures;
        }

		// Метод для расчета общей стоимости мебели в комнате
		public double GetPrice()
        {
            double price = 0;
            foreach(Furniture furniture in Furnitures) price += furniture.Price;
            return price;
        }

    }

    public class Furniture
    {
        public string Name { get; set; }
        
        public double Price { get; set; }

        public Furniture(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
