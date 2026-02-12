using System;

namespace PropertiesClass
{
    class Student // Задание 1
    {
        public string Name { get; set; } = string.Empty;

        public override string ToString() => $"Студент: {Name}";
    }

    class Child // Задание 2
    {
        public int Age { get; set; }

        public Child() => Console.WriteLine("Создан объект Child");

        public override string ToString() => $"Ребёнок, возраст: {Age}";
    }

    class Car // Задания 3–4
    {
        private int year;

        public int Year
        {
            get => year;
            set
            {
                if (value > 0)
                    year = value;
                else
                    Console.WriteLine("Ошибка: год должен быть положительным числом");
            }
        }

        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;

        public Car() => Console.WriteLine("Создан объект Car");

        public override string ToString() =>
            $"Автомобиль: {Name}, Год: {Year}, Цвет: {Color}";
    }

    class Product // Задание 5
    {
        private string name;

        public string Name
        {
            get => name;
            private set => name = value ?? string.Empty;
        }

        public Product()
        {
            name = "Рамиль";
            Console.WriteLine("Создан объект Product");
        }

        public override string ToString() => $"Товар: {Name}";
    }

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Выполнение заданий ===\n");

            // Задание 1
            var student = new Student { Name = "Анна" };
            Console.WriteLine(student);

            // Задание 2
            var child = new Child { Age = 10 };
            Console.WriteLine(child);

            // Задание 3
            var car = new Car();
            car.Year = 2023;
            car.Name = "Неизвестный";
            car.Color = "серый";
            Console.WriteLine(car);

            // Задание 4
            var kia = new Car
            {
                Name = "KIA SOUL",
                Color = "green",
                Year = 2022
            };
            Console.WriteLine(kia);

            // Задание 5
            var product = new Product();
            Console.WriteLine(product);

            Console.WriteLine("\n=== Программа завершена ===");
        }
    }
}