using PatternStrategy.Implementations;
using System;

namespace PatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck duck = new MallardDuck();

            duck.Display();
            duck.Swim();

            duck.PerformFly();
            duck.PerformQuack();

            duck.SetFlyBehavior(new FlyNoWay()); // динамически меняем поведение

            duck.PerformFly();

            Console.ReadKey();
        }
    }
}
