using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    //1 адание
    class Student
    {
        public string name;
    }
    //2 задание 
    class Car
    {
        public int year;
    }
    //3 задание
    class Point
    {
        public int x;
    }
    //4 задание
    class Person
    {
        public int age;
        public void Print()
        {
            Console.WriteLine($"Возраст: {age}");
        }
    }
    //5 задание
    class Table
    {
        public int rows, cols;

        public void Display()
        {
            Console.WriteLine($"Строки: {rows}, Столбцы: {cols}");
        }
    }
    //6 задание
    class Manager
    {
        public int age;
        public string name;
        public void GetAge()
        {
            Console.WriteLine($"Возраст: {age}");
        }
        public void GetName()
        {
            Console.WriteLine($"Имя: {name}");
        }

    }
    //7 задание
    class Point3D
    {
        public int x, y, z;
        public void Show()
        {
            Console.WriteLine($"X:{x}, Y:{y}, Z:{z}");
        }
    }
    //8 задание
    class Shop
    {
        public string name, newname;
        public void GetName()
        {
            Console.WriteLine($"Название магазина: {name}");
        }
        public void SetName()
        {
            name = newname;
            Console.WriteLine($"Новое название магазина: {name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //4 задание

            Person person1 = new Person();
            person1.age = 10;
            person1.Print();

            //5 Задание

            Table tab1 = new Table();

            tab1.rows = 12;
            tab1.cols = 21;
            tab1.Display();

            //6 задание

            Manager manager1 = new Manager();

            manager1.age = 88;
            manager1.name = "Виталий";
            manager1.GetAge();
            manager1.GetName();

            //7 Задание

            Point3D kek = new Point3D();

            kek.x = 56;
            kek.y = 78;
            kek.z = 42;
            kek.Show();

            //8 задание

            Shop shop1 = new Shop();

            shop1.name = "Цветочный";
            shop1.newname = "Роза";
            shop1.GetName();
            shop1.SetName();
        }
    }
}