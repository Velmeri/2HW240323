using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2HW240323
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Создание объектов мебели
			Furniture chair = new Furniture("Chair", 50.00);
			Furniture table = new Furniture("Table", 100.00);
			Furniture sofa = new Furniture("Sofa", 200.00);

			// Создание списков мебели для каждой комнаты
			List<Furniture> livingRoomFurniture = new List<Furniture>() { chair, table, sofa };
			Room livingRoom = new Room(livingRoomFurniture);

			// Создание объектов комнат с передачей списков мебели в конструкторы
			List<Furniture> bedroomFurniture = new List<Furniture>() { chair, table };
			Room bedroom = new Room(bedroomFurniture);

			// Создание списка комнат для здания и добавление объектов комнат
			List<Room> rooms = new List<Room>() { livingRoom, bedroom };

			// Создание объекта здания с передачей списка комнат и имени в конструктор
			Building house = new Building("My House", rooms);

			// Вызов метода расчета общей стоимости мебели в здании
			double totalPrice = house.GetPrice();

			// Вывод общей стоимости мебели в консоль
			Console.WriteLine($"The total price of all the furniture in the house is: {totalPrice}");

			// Финиш
			Console.ReadKey(true);
		}
    }
}
