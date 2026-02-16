using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Student
    {
        // Конструктор по умолчанию для задания 1
        public Student()
        {
            Console.WriteLine("Создан объект Student");
        }
    }

    class Child
    {
        // Конструктор по умолчанию для задания 2
        public Child()
        {
            Console.WriteLine("Создан объект Child");
        }
    }

    class Car // Задания 3–4
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        // Конструктор с параметром года выпуска (задание 3)
        public Car(int year)
        {
            Year = year;
            Console.WriteLine($"Создан автомобиль года: {year}");
        }

        // Конструктор с параметрами названия и цвета (задание 4)
        public Car(string name, string color)
        {
            Name = name;
            Color = color;
            Console.WriteLine($"Создан автомобиль: {name}, цвет: {color}");
        }

        // Метод для вывода информации об автомобиле
        public void DisplayInfo()
        {
            Console.WriteLine($"Автомобиль: {Name}, Год: {Year}, Цвет: {Color}");
        }
    }

    class Product // Задание 5
    {
        protected string Name;

        public Product(string name)
        {
            Name = name;
            Console.WriteLine($"Создан товар: {name}");
        }

        // Копирующий конструктор
        public Product(Product other)
        {
            Name = other.Name;
            Console.WriteLine($"Скопирован товар: {Name}");
        }

        // Метод для вывода названия товара
        public void DisplayName()
        {
            Console.WriteLine($"Название товара: {Name}");
        }
    }

    class Person // Задание 6
    {
        private int Age;

        public Person()
        {
            Age = 18;
            Console.WriteLine("Создан человек с возрастом по умолчанию (18 лет)");
        }

        public void Print()
        {
            Console.WriteLine($"Возраст: {Age}");
        }
    }

    class Manager // Задание 7
    {
        private int Age;
        private string Name;

        public Manager(int age, string name)
        {
            Age = age;
            Name = name;
            Console.WriteLine($"Создан менеджер: {name}, возраст: {age}");
        }

        // Копирующий конструктор
        public Manager(Manager other)
        {
            Age = other.Age;
            Name = other.Name;
            Console.WriteLine($"Скопирован менеджер: {Name}, возраст: {Age}");
        }

        // Метод для вывода информации о менеджере
        public void DisplayInfo()
        {
            Console.WriteLine($"Менеджер: {Name}, Возраст: {Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Выполнение заданий ===\n");

            // Задание 1
            Student student = new Student();

            // Задание 2
            Child child1 = new Child();

            // Задание 3
            Car car = new Car(2025);

            // Задание 4
            Car lada = new Car("LADA VESTA", "black");
            Car bmw = new Car("BMW X5", "white");

            // Вывод информации об автомобилях
            car.DisplayInfo();
            lada.DisplayInfo();
            bmw.DisplayInfo();

            // Задание 5
            Product p1 = new Product("первый товар");
            Product p2 = new Product(p1);

            p1.DisplayName();
            p2.DisplayName();

            // Задание 6
            Person person = new Person();
            person.Print();

            // Задание 7
            Manager manager1 = new Manager(20, "Дамир");
            Manager manager2 = new Manager(18, "Сара");

            manager1.DisplayInfo();
            manager2.DisplayInfo();

            Console.WriteLine("\n=== Программа завершена ===");
        }
    }
}