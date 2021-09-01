using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation1
{
    class Program
    {
        static void Main(string[] args)
        {
            bank obj = new bank();
            customer ob1 = new customer();
            obj.details();
            ob1.validate();
        }
    }
    class customer
    {
        public long acc { get; set; }
        public string name { get; set; }
        public int pinentered { get; set; }
        private int atmpin = 1234;
         public void validate()
        {
            if(pinentered==atmpin)
            {
                Console.WriteLine("The pin entered is correct");
            }
            else
                Console.WriteLine("The pin entered is incorrect");


        }
    }
    class bank
    {
        public customer details()
        {
            customer a = new customer();
            Console.WriteLine("Enter the number of account holder");
            a.acc = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the name of account");
            a.name = Console.ReadLine();
            Console.WriteLine("Enter the pin of account");
            a.pinentered = Convert.ToInt32(Console.ReadLine());
            return a;
        }
      
    }
}
