using System;

namespace _02_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            if (number==10)
            {
                Console.WriteLine("Numbers is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }


            //Single Line if yazım tekniği
            Console.WriteLine(number == 10 ? "Number is 10 ":"Number is not 10 ");

            
            // ornek 3

            if (number == 10)
            {
                Console.WriteLine("Number is 10 ");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");

            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }



            // Switch - Case 

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10 ");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20 ");
                    break;
                    
            }
          

            //if else  ornek 2

            if (number >= 0  && number <= 100)
            {
                Console.WriteLine("Number is between 0-100 ");
            }
            else if (number > 100 && number <=200)
            {
                Console.WriteLine("Number is between 101 - 200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 101-200");
            }


            // iç içe if 

            if (number < 100)
            {
                if (number >= 90  && number < 100)
                {
                    Console.WriteLine("Number is 90 beetween 100 ");
                }
            }
           



            Console.ReadLine();
        }
    }
}
