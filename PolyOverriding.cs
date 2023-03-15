using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConAssigment1
{
    //internal class PolyOverriding
     public class Animal
    {
        public virtual void Run()
        {
            Console.WriteLine("Animal running slowely");
        }
    }
    class Lion : Animal
    {
        public override void Run()
        {
            Console.WriteLine("Lion is running fast");
        }
    }
    }

