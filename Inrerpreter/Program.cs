using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inrerpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AttractionCollection collection = new AttractionCollection();
            collection.AddItem("Colosseum");
            collection.AddItem("Tower");
            collection.AddItem("Restaraunt");
            collection.AddItem("Trevi Fountain of Rome");
            collection.AddItem("Must see: Pantheon");
            collection.AddItem("St. Peter’s Basilica");
            collection.AddItem("Roman sights of Forum Romanum & Palatine");


            foreach (var item in collection)
            {
                Console.WriteLine("You've visited " + item + " !");
            }
        }
    }
}
