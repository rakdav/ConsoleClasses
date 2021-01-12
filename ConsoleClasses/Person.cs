using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasses
{
    class Person
    {
        public string fio;
        public int age;
        public double rost;
        public double weight;

        public Person()
        {
        }

        public Person(string fio, int age, double rost, double weight)
        {
            this.fio = fio;
            this.age = age;
            this.rost = rost;
            this.weight = weight;
        }

        public string getFIO()
        {
            return fio;
        }

        public int getAge()
        {
            return age;
        }

        public double getRost()
        {
            return rost;
        }

        public double getWeight()
        {
            return weight;
        }

        public void Print()
        {
            Console.WriteLine(this.getFIO() + " " + this.getAge() + " " + this.getRost() + " " + this.getWeight());
        }

        public void setFio(string fio)
        {
            this.fio = fio;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setRost(double rost)
        {
            this.rost = rost;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }
    }
}
