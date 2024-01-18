using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo2
{
    internal class Demo3
    {
        public int num;

        public void GetDetails()
        {
            Console.WriteLine("Enter a value");
            num = Convert.ToInt32(Console.ReadLine());
        }



        public static bool operator >(Demo3 obj1, Demo3 obj2)
        {
            if (obj1.num > obj2.num)
                return true;
            else
                return false;

        }

        public static bool operator <(Demo3 obj1, Demo3 obj2)
        {
            if (obj1.num < obj2.num)
                return true;
            else
                return false;

        }
    }
}
