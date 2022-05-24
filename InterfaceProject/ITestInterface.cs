using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal interface ITestInterface1
    {
        void add(int a, int b);
        
    }

    interface ITestInterface2 : ITestInterface1
    {
        void sub(int a, int b);
    }

    class ImplementationClass : ITestInterface2
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main()
        {
            ImplementationClass obj = new ImplementationClass();
            obj.add(100, 30);
            obj.sub(78, 23);
            ITestInterface2 i1 = obj;
            i1.add(1, 2);
            i1.sub(1, 2);
            ITestInterface1 i2 = obj;
            i2.add(1, 2);
            Console.ReadLine();
        }
    } 
}
