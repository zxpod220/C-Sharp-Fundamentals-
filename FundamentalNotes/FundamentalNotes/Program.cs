using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalNotes
{
    class Program
    {
        static void Main(string[] args)
        {
// Simple Hello World

            Console.WriteLine("Hello World");


// Primitive Types
//everything that is blue is a keyword.

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Your Name";
            bool isWorking = false;

//uncomment to see what they do. 

            /*
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            */

/* The Keyword "var" makes variable declarations easier.
*and the c# compiler detects the data type
*if you hover your mouse over the var it will tell you 
*what datatype you put. */

            var numberb = 2;
            var countb= 10;
            var totalPriceb = 20.95f;
            var characterb = 'B';
            var firstNameb = "Your Name";
            var isWorkingb = false;

//uncomment to see what they do.

            /*
            Console.WriteLine(numberb);
            Console.WriteLine(countb);
            Console.WriteLine(totalPriceb);
            Console.WriteLine(characterb);
            Console.WriteLine(firstNameb);
            Console.WriteLine(isWorkingb);
            */

/* Lets find the range that we can store in a byte
*and in a float, we can do this by .MinValue and MaxValue
*Uncomment to find out what these two lines do. */

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


//Constants  
// Uncomment to see what happens    

            //const float Pi = 3.14f;
            // Pi = 1; The compiler is not happy about this line. 


//Type Conversion

            /*
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            */

//Lets reverse this

            // int i = 1;
            //byte b = i;


//The compiler doesn't like this, because you are missing a cast. 
            /*
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);
            */
//Try replacing 1 with a 1000 and see what happens to b.

            /*
            var numberc = "1234";
            int i = Convert.ToInt32(numberc);
            Console.WriteLine(i);
            */
//change int to byte and ToInt32 to byte and see why the program will crash. 


/*Try catch statements will try out your statements and if there is an error it will
*catch it and throw a nice message that you type. */

            /*e.g. 1
            try
            {
            var numberc = "1234";
            byte i = Convert.ToByte(numberc);
            Console.WriteLine(i);
            }
            catch (Exception)
            {
             Console.WriteLine("The number could not be converted to a byte.");

            }*/

            /*e.g. 2

             try
            {
            string str = "true";
            bool b = Convert.ToBoolean(str);
            Console.WriteLine(b);
            }
            catch (Exception)
            {

            Console.WriteLine("This string could not be converted into a boolean");

            }*/

// Operators

            var a = 10;
            var b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine((float)a / (float)b);

            var c = 1;
            var d = 2;
            var e = 3;
            Console.WriteLine(c + d * e); //result should be 7
            Console.WriteLine((c + d) * e); //result should be 9
            Console.WriteLine(c > d); // comparison expresion is always true or false.
            Console.WriteLine(c == d);
            Console.WriteLine(c != d);
            Console.WriteLine(!(c != d));
            Console.WriteLine(e > d && d > c);
            Console.WriteLine(e > d && e == c);
            Console.WriteLine(e > d || e == c);
            Console.WriteLine(!(e > d || e == c));
        }
    }
}
