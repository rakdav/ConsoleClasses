using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Vasia = new Person("Вася Пупкин",30,180,89);
            Vasia.Print();
            Person Kolya = new Person("Коля Васечкин",18,180,79);
            Kolya.Print();
            Kolya.setWeight(85);
            Kolya.Print();
            Person Boris = new Person { fio = "Борис Первый", age = 23, rost = 178, weight = 68 };
            double R = double.Parse(Console.ReadLine());
            Circle circle = new Circle(R);
            circle.Print();

            Console.Write("Введите массу:");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите скорость:");
            double v = double.Parse(Console.ReadLine());
            Energy energy = new Energy(m,v);
            energy.Print();

            Employer[] employers = new Employer[5];
            for(int i=0;i<employers.Length;i++)
            {
                string name = Console.ReadLine();
                string post = Console.ReadLine();
                double oklad = double.Parse(Console.ReadLine());
                employers[i] = new Employer(name, post, oklad);
            }
            for (int i = 0; i < employers.Length; i++)
            {
                employers[i].Print();
                employers[i].Add();
                employers[i].Change();
            }
            for (int i = 0; i < employers.Length; i++)
            {
                employers[i].Print();
            }

            Console.ReadKey();
        }
    }
}
