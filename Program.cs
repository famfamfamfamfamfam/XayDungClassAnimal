using System;
namespace LOPVADOITUONG
{
    public abstract class Animal
    {
        protected string weight { get; set;}
        protected string height { get; set; }
        public Animal(string weight, string height)
        {
            this.weight = weight;
            this.height = height;
        }
        public abstract void PrintInfo();
    }
    public class Cat : Animal
    {
        string Name { get; set; }
        public Cat(string weight, string height, string name) : base(weight, height)
        {
            Name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Weight : {weight}\nHeight : {height}\nName : {Name}");
        }
    }
    public class ThucThi
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat("6kg", "20cm", "Mimi");
            cat.PrintInfo();
        }
    }
}