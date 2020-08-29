using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2int
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = null;
            string number = null;
            Console.Write("Enter text : ");
            text = Console.ReadLine();
            char[] textChar = text.ToCharArray();
            foreach(char c in textChar)
            {
                if (Char.IsNumber(c))
                {
                    number += c;
                }
            }
            Console.WriteLine("Output : " + number);
            Console.Read();
        }
    }
}
