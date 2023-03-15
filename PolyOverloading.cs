using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace OopsConAssigment1
{
    //internal class PolyOverloading
    public class Overloading
    {
        public void Add(int a , int b)
        {
            Console.WriteLine("addition of two number" + a + b);
        }
        public void Add(float a, float b)
        {
            Console.WriteLine("addition of two number" + a + b);
        }
        public void Add(int a, float b, float c)
        {
            Console.WriteLine("addition of two number" + a + b+c);
        }
        public void Add(float a, int b, float c)
        {
            Console.WriteLine("addition of two number" + a + b + c);
        }

    }

    }

