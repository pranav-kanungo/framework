using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    class Program
    {
        static void Main(string[] args)
        {
            test obj = new test();
           int a= obj.add(6, 7);
            int b=obj.sub(7, 8);
            Console.WriteLine("the values are" +"  " +a +"  " +b);

        }
    }
    public partial class test
    {
        public int add(int a, int b)
        {
            int c = a + b;
            return c;
        }

    }
    public partial class test
    {
        public int sub(int a, int b)
        {
        int c = a - b;
        return c;
        }
    }
}
