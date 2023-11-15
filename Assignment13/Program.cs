using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice:1.word count\n2.email-validation\n3.mobile validation\n4.custom validation");
            int ch=int.Parse(Console.ReadLine());
            
            Mtds mtds = new Mtds();
            if (ch == 1)
            {
                Console.WriteLine("enter text");
                string st = Console.ReadLine();
                mtds.userinp(st);
            }
            else if(ch == 2)
            {
                Console.WriteLine("enter email");
                string st = Console.ReadLine();
                mtds.mail(st);
            }
            else if(ch==3)
            {
                Console.WriteLine("enter text");
                string st = Console.ReadLine();
                mtds.mobile(st);
            }

            if (ch == 4)
            {
                Console.Write("Enter a text for regex search: ");
                string inputText = Console.ReadLine();
                Console.Write("Enter a custom regular expression: ");
                string customRegex = Console.ReadLine();
                mtds.PerformCustomRegexSearch(inputText, customRegex);

            }
        }
    }
}
