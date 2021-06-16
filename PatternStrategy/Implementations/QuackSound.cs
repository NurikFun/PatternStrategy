using PatternStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Implementations
{
    public class QuackSound : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack, quack, quack...");
        }
    }
}
