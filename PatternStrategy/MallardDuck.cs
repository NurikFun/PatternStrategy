using PatternStrategy.Implementations;
using PatternStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackSound();
        }

        public override void Display()
        {
            Console.WriteLine("I am mallard duck!");
        }
    }
}
