using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Kadry
    {
        private string fam;
        private double age;
        private string dol;
        private double staj;

        public Kadry() { }
        public Kadry(string fam, double age, string dol, double staj) 
        {
            this.Fam = fam;
            this.Age = age;
            this.Dol = dol;
            this.Staj = staj;

        }

        public double Age
        {
            get { return age; }
            set
            {
                if (value < 16) age = 16;
                else if (value > 60) age = 60;
                else age = value;
            }
        }

        public double Staj
        {
            get { return staj; }
            set
            {
                if (value < 0) staj = 0;
                else if (value > 45) staj = 60;
                staj = value;
            }
        }

        public string Fam { get => fam; set => fam = value; }
        public string Dol { get => dol; set => dol = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Фамилия: {Fam}\n Возраст: {age}\n Должность: {Dol}\n Стаж: {staj}");
        }
    }
}
