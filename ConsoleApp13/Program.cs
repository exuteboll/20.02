using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kadry kadry = new Kadry();
            kadry.Fam = "Фамилия";
            kadry.Age = 26;
            kadry.Dol = "Должность";
            kadry.Staj = 30;
            kadry.ShowInfo();
            string fam1 = Console.ReadLine();
            double age1 = double.Parse(Console.ReadLine());
            string dol1 = Console.ReadLine();
            double staj1 = double.Parse(Console.ReadLine());
            Kadry kadry1 = new Kadry(fam1, age1, dol1, staj1);
            kadry1.ShowInfo();
            Kadry kadry3 = new Kadry("asd",40,"sdg",31);
            kadry3.ShowInfo();

            Console.ReadKey();
            
        }
    }
}
