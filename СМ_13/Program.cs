using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМ_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Цветочная 3-5", 15000, 10000, 27000);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Абрикосовая 5-3", 15000, 15000, 54000, 18);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
