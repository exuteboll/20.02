using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto avto = new Avto("","Белый",80);
            avto.ShowInfo();
            Avto avto1 = new Avto("BMW", "", 200);
            avto1.ShowInfo();
            Avto avto2 = new Avto("Opel", "Красный", 90);
            avto2.ShowInfo();
            Console.ReadKey();

        }
    }
}
