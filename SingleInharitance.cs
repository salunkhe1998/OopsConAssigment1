using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConAssigment1
{
    //internal class SingleInharitance
    public class Animal
    {
        public void eat() { Console.WriteLine("Eating..."); }
    }
    public class Dog : Animal
    {
        public void bark() { Console.WriteLine("Barking..."); }
    }
    class TestInheritance2
    {  
    
    }
}
