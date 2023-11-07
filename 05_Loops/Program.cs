internal class Program
{
    private static void Main(string[] args)
    {
        //Loops veri kümelerini dolaşma işine yarar.
        ForLoops();
        WhileLoop();
        DoWhileLoop();
        ForEach(); 

        //Asal sayı uygulaması
        if (IsPrimeNumber(6))
        {
            Console.WriteLine("This is a prime number");
        }
        else
        {
            Console.WriteLine("This is not a prime number");
        }


        // Tek çift uygulaması
        if (TekMi(8))
        {
            Console.WriteLine("Tek");
        }
        else
        {
            Console.WriteLine("Çift");
        }


        Console.ReadLine(); // Consolda bekletme işlemi



    }
    private static bool TekMi(int number)
    {
        bool result = true;
        if (number % 2 == 0)
        {
            result = false;


        }
        else if (number % 2 == 1)
        {
            result = true;
        }
        return result;

    }
    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number - 1; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;
            }
        }
        return result;

    }


    private static void ForEach()
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };
        foreach (var student in students)
        {
            //Data geziminde kullanılır veya dolaşılabilir nesnelerde kullanılır
            Console.WriteLine(student);
        }

        string[] books = new string[] { "Java", "C#", "C", "C++" };
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {    //şart sağlanmasada bir kere çalışır
            Console.WriteLine(number);
            number--;
        }
        while (number >= 0);

        int number2 = 1;
        do
        {
            Console.WriteLine(number2);
            number2 *= 3;
        } while (number2 <= 100);
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine("Now number is : {0}", number);
            number--;

        }
        int number2 = 1;
        while (number2 <= 100)
        {
            Console.WriteLine("Now number is : {0}", number2);
            number2 *= 3;
        }
    }

    private static void ForLoops()
    {
        for (int i = 0; i <= 100; i++) // i+=2  i= i+2
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Finished");

        for (int i = 1; i < 50; i *= 3)
        {

            Console.WriteLine("Sayimiz:{0} ", i);

        }

        Console.WriteLine("İşlem bitti");
    }
}
