using System;

namespace _01_TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types 
            //Int  32 bit yer tutar
            Console.WriteLine("Int");
            int number1 = +2147483647; //integer veri tipi sınırları
            int number2 = -2147483647;

            Console.WriteLine("Number 1 is {0} {1}", number1, number2);


            //Long 64 bit yer tutar
            Console.WriteLine("Long");
            long number3 = 9223372036854775807;
            Console.WriteLine("number 3 is {0}", number3);


            //Short 16 bit yer tutar
            Console.WriteLine("Short");
            short number4 = -32768;
            short number5 = 32767;
            Console.WriteLine("number 4 : {0} , number5 : {1} ", number4, number5);

            // Byte 
            Console.WriteLine("Byte");
            byte number6 = 255; // 0 - 255 arası veri tutar
            Console.WriteLine("number 6 : {0} ", number6);


            // Bool 
            Console.WriteLine("Bool");
            bool condititon = false;
            Console.WriteLine(condititon);

            //Char
            Console.WriteLine("Char");
            char character = 'a';
            string city = "Kahramanmaraş"; // stringler karakter dizileridir
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character is : {0}", (int)character); // karakter veri tipi int değere dönüştürüldü

            //Double  64 bit veri tutar
            Console.WriteLine("Double");
            double number7 = 10.4;
            Console.WriteLine("Number 7 is : {0}", number7);


            //Decimal 
            Console.WriteLine("Decimal");
            decimal number8 = 10.4m;
            Console.WriteLine("Number 8 is : {0}", number8);


            //Enum 
            Console.WriteLine("Enum");
            Console.WriteLine((int)Days.Friday);


            //Var
            Console.WriteLine("Var");
            var number9 = 1000;
            number9 = 'A';
            Console.WriteLine("Number 9 is : {0}", number9);


            Console.WriteLine("Hello World!");
        }
    
    enum Days
    {
        Monday = 10, Tuesday = 20, Wednasday = 30, Thursday = 40, Friday = 50, Saturday, Sunday, Wednesday,
    }
}
    }

