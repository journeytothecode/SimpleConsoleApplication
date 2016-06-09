using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleconsoleapplication
{
    class Program
    {
        static void Main(string[] args)
        
{
            Console.WriteLine("this is the simple one for reboot the programming skills.");
            Console.WriteLine("The different ways of keeping console windows open !");


            //this is the simple of formatting money
            Console.WriteLine("This is the simple of formatting currency: {0:c} and: {1:c} ",36,45);

            // this is the simple of formatting decima number with 4 decimal places
            Console.WriteLine("this is the simple of formatting decima number with 4 decimal places: {0:F4} \n and 5 places {1:f5} \n and 10 places {2:F10}",1.02020,15.64554565,19.131313131313158);


            // this is the simple formatting with percentage numbers
            Console.WriteLine("this is the simple formmating with percentage numbers: {0:p1} \n and {1:p0}",10.12,300.1);

            //this is the simple of datatype
            int i = 3; // normally use for integer variable
            double longandlength = 9936.2166;
            decimal money = 99.4M;

            Console.WriteLine("This is integer {0} \nThis is Double {1} \nThis is Decimal {2}",i.ToString(),longandlength.ToString(),money.ToString());
            //Console.WriteLine("this is Double");

            //Console string interaction with user via commandline

            string[] lines = new string[2];
            Console.WriteLine("Please input line one");
            lines[0] = Console.ReadLine();
            Console.WriteLine("Please input line two");
            lines[1] = Console.ReadLine();

            //string copystring = lines[0] +" "+ lines[1];
            //Console.WriteLine(copystring);
            string copystring1 = string.Copy(lines[0]+" "+lines[1]);
            //Console.WriteLine(copystring1);

            //places holder syntax for string variable
            Console.WriteLine("This is line 1 {0} followed by line 2 {1}",lines[0].ToString(),lines[1].ToString()); 


            int x,y;
            Console.WriteLine("Please input X variable :");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input Y variable :");
            y = int.Parse(Console.ReadLine());

            //print out the maths of x and y
            //int total = x + y;
            Console.WriteLine((x + y).ToString());
            Console.WriteLine("Total of X an Y is {0}", (x + y).ToString());

            //int sub = x - y;
            Console.WriteLine("Suctraction on X an Y is {0} ", (x-y).ToString());

            Console.WriteLine(x-y);

            Console.WriteLine("this is just a test");









            Console.WriteLine("this is the commitment for the \n hello world");
        
            Console.Read();
            //Console.ReadKey();

        }
    }
}
