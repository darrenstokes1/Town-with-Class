using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    class TownHouse
    {
        static void Main(string[] args)
        {
            House house = new House(); // Create new house

            house.BldgType = "double-wide trailer";
            string housetype = house.BldgType;

            house.Name = "la ranchero";
            string ranchero = house.Name;


            Console.WriteLine($"{housetype} : {ranchero}");
            Console.ReadLine();
        }
    }

}
