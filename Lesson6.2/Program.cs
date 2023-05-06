using System;

namespace FirstApp
{
    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Метод класса
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }

    class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public Rectangle(int x)
        {
            a = x;
            b = x;
        }
        public Rectangle(int x, int y)
        {
            a = x;
            b = y;
        }
        public int Square()
        {
            return a * b;
        }
    }

    struct Animal
    {
        // Поля структуры
        public string type;
        public string name;
        public int age;

        // Метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human.name = "Дмитрий";
            human.age = 23;
            human.Greetings();


            Console.ReadKey();
        }
    }
}