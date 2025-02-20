using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Avto
    {
        private string model;
        private string color;
        private double skor;
        public double Skor
        {
            get { return skor; }
            set
            {
                if (value < 60) skor = 60;
                else if (value > 150) skor = 150;
                else skor = value;
            }
        }


        public string Model
        {
            get { return 
                    (model!="")?model:"Неизвестно"; }
            set { model = value; }
        }
        public string Color
        {
            get { return
                    (color != "") ? color:"Неизвестно" ; }
            set { color = value; }
        }
        public Avto() { }
        public Avto(string model, string color, double skor)
        {
            this.Model = model;
            this.Color = color;
            this.Skor = skor;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {Model}\n Цвет: {Color}\n Скорость: {Skor} ");
        }

        

    }
}
