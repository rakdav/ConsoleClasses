using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasses
{
    class Energy
    {
        private double massa;
        private double velocity;
        public Energy(double massa, double velocity)
        {
            this.massa = massa;
            this.velocity = velocity;
        }
        private double KineticeEnergy()
        {
            return massa * velocity * velocity / 2;
        }

        public void Print()
        {
            Console.WriteLine("Масса:"+massa+" Скорость:"+velocity+" Кинетическая энергия:"+KineticeEnergy());
        }
    }
}
