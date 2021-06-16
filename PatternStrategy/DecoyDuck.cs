using PatternStrategy.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
