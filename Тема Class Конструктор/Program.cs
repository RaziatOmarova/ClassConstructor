using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_Class_Конструктор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ЕдаБогов = new Person("Хинкалы", "Аварский", "Ромб");
            Person ЕдаБогов2 = new Person("Хинкалы", "Кумыкский", "Квадрат");
            Person ЕдаБогов3 = new Person("Хинкалы", "Кукурузный", "Круг");
            
            Console.ReadKey();
        }
    }

    class Person
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string shape { get; set; }

        public Person(string name, string lastName, string shape)
        {
            this.name = name;
            this.lastName = lastName;
            this.shape = shape;
            Console.WriteLine($"Блюдо: {this.name}, Вид: {this.lastName}, Форма: {this.shape}");
        }
    }
}
