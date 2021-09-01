using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            logic obj = new logic();
            Console.WriteLine("Which operation you want to perform 1.Add 2.Square");
            int a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine("enter 2 number to add");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    int x= obj.logics(b,c);
                    Console.WriteLine("The ans is" + x);
                    break;
                case 2:
                    {
                        Console.WriteLine("enter the number to square");
                        int d = Convert.ToInt32(Console.ReadLine());
                       int q= obj.logics(d);
                        Console.WriteLine("The ans is" + q);
                        break;
                    }
            }
        }
    }
    class logic
    {
        public int logics(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int logics(int a)
        {
        int c = a*a;
        return c;
        }
    }
}
