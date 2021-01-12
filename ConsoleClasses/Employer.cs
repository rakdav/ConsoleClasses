using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasses
{
    class Employer
    {
        private string firstName;
        private string post;
        private double oklad;

        public Employer(string firstName, string post, double oklad)
        {
            this.firstName = firstName;
            this.post = post;
            this.oklad = oklad;
        }

        public void Add()
        {
            this.oklad+=this.oklad*0.15;
        }

        public void Change()
        {
            if (firstName.StartsWith("Иван"))
                post = "инженер";
        }
        public void Print()
        {
            Console.WriteLine("Фамилия:"+this.firstName+" Должность:"+this.post+" Оклад:"+this.oklad);
        }
    }
}
