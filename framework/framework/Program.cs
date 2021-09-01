using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    class Program
    {
        static void Main(string[] args)
        {
            students x = new students();
            Console.WriteLine("enter the value");
            int v = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            int ans=x.a(v, b);
            Console.WriteLine("the value is" + ans);

        }
    }
    class students
    {
        public int c;
        public int a(int a, int b)
        {
            c = a + b;
            return c;
        }
       
    }
}
