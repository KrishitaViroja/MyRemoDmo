using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
    internal class StArray
    {
        string[] arr = new string[10] {"abc","def","ghi","jkl","seeta","sanjana" ,"sheetal", "aditi", "aisha", "anjali"};
        public void DisplayString()
        {
            IEnumerable<string> result = from a in arr
                                         where (a.StartsWith('s') && a.Length > 5)
                                         select a;
            foreach (string a in result)
            {
                Console.WriteLine($"{a}");
            }

        }
        
       
        
}
}
