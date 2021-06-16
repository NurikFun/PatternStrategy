using PatternStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Implementations
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }
        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("I am swimming...");
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior) // для динамического изменения поведения
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

        public void PerformFly() // инкапсулируйте то, что изменяется 
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

    }
}
