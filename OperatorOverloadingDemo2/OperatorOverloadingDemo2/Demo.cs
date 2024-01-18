using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo2
{
    internal class Demo
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


        public Demo Add(Demo obj2)
        {
            Demo obj3 = new Demo();
            obj3.num = this.num + obj2.num;
            return obj3;

        }
        public static Demo operator -(Demo obj1, Demo obj2)
        {
            Demo obj3 = new Demo();
            obj3.num = obj1.num - obj2.num;
            return obj3;
        }

        public static Demo operator +(Demo obj1, Demo obj2)
        {
            Demo obj3 = new Demo();
            obj3.num = obj1.num + obj2.num;
            return obj3;
        }
    }
}
