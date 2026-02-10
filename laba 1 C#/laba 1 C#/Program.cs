using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_C_
{
    internal class Program
    {
        static void Main()
        { 
            Class1 ryad = new Class1();
            ryad.value = "zadacha";
            ryad.show();
            Console.WriteLine("Довжина: " + ryad.lenght());
            ryad.sort();
            Console.WriteLine("Відсортована: ");
            ryad.show();
        }
    }
}