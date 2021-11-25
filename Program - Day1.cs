using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Number data types - byte,short,int,long,float,double
             * String data types - char, string
             * boolean - True, False
             * whole number constant -- integer
             * real point constant -- double
             */
            Console.WriteLine("Welcome to DotNet");

            int j = 100, k = 200;
            byte b = 100;
            try
            {
                int b2 = 0;
                int c = 5 / b2;
                byte b1 = Convert.ToByte(-2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            short s1 = 456;
            //short s1 = null;
            Console.WriteLine("bye");
            

            int i = s1;//456
            s1 = 456;
           // s1 = (short)456000;// constant
            s1 = (short)i;//bigger data type cannot be converted to smaller data type implicitly
            float f1 = 123;
            //float f2 = 123.23;//double cannot be converted implicitly
            float f3 = 123.23f;
            // read values from user:
            Console.WriteLine("Enter a number");//123, -123,vhjghj,123.23
            char c1=(char)Console.Read();
            Console.WriteLine("The entered number is " + c1);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            var num1=Console.ReadKey();
            Console.WriteLine(num1);

            Console.WriteLine("Enter a number");
            //int num2=(int)Console.ReadLine();
            // convert a string to int -- cannot convert using explicit typecasting
            int num2;
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num2);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Please enter only digits");

            }

            int num3;
            Console.WriteLine("Enter a number -- Parse method will be used");
            //num3 = Int32.Parse(null);// will throw a ArgumentNullException
            num3 = Int32.Parse(Console.ReadLine());

            int num4;
            Console.WriteLine("Enter a number -- TryParse method will be used");
            bool isCoversionSuccessful=Int32.TryParse(Console.ReadLine(),out num4);
            if(isCoversionSuccessful)
            {
                Console.WriteLine("The entered value is " + num4);
            }
            else
            {
                Console.WriteLine("Please enter only digits");
            }

            int num5=0;
            bool checkInput = false;
            while(checkInput==false)
            {
                Console.WriteLine("Enter a number(Only digits)");
                checkInput=Int32.TryParse(Console.ReadLine(), out num5);
            }
            Console.WriteLine("The entered number is " + num5);

            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadLine();
        }
    }
}
// Data type and corresponding range of values
// how can i store null in s1

/*js
 * 
 * var n1=100;
 * var n2=new Number(100);
 * 
 */