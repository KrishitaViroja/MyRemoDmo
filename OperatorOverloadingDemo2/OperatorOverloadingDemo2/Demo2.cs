using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo2
{
    internal class Demo2
    {
        public int num;

        public void GetDetails()
        {
            Console.WriteLine("Enter a value");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Num : {0}", num);
        }

        public static Demo2 operator ++(Demo2 obj1)
        {
            Demo2 obj2 = new Demo2();
            obj2.num = obj1.num++;
            return obj2;
        }
        public static Demo2 operator --(Demo2 obj1)
        {
            Demo2 obj2 = new Demo2();
            obj2.num = obj1.num--;
            return obj2;


        }

    }
}
