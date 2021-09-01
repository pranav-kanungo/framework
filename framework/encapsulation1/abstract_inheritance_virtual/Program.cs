using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_inheritance_virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            function obj = new function();
            Console.WriteLine("Enter the function you want to perform 1. Add 2.Sub");
            int x = Convert.ToInt32(Console.ReadLine());
            switch(x)
            {
                case 1:
                    int c = obj.add();
                    Console.WriteLine("value" + c);
                    break;
                case 2:
                    Console.WriteLine("Enter the values to Sub");
                    int f = Convert.ToInt32(Console.ReadLine());
                    int e = Convert.ToInt32(Console.ReadLine());
                    int d = obj.add(f, e);
                    Console.WriteLine("value" + d);
                    break;
            }
           
            
            
        }
    }
    public abstract class abs
    {
       public abstract int add();
       public virtual int add(int a, int b)
        {
            int c = a + b;
            return c;
        }

    }
    public class function : abs
    {
        int d;
        int e;
        public override int add()
        {
            Console.WriteLine("Enter the values to add");
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            int c = d + e;
            return c;
        }
        public override int add(int a, int b)
        {
            int c = a - b;
            return c;
        }

    }

}
