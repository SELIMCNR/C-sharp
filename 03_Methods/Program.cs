internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Methods ");

        Add();
        Add();
        var result = Add2(20, 30);
        Console.WriteLine(result);

        int number1 = 20;
        int number2 = 100;
        var result2 = Add3(ref number1, number2); // ref referance olarak method içindeki değeri al   //methode değerini direkt değişkenlerden aldı
        Console.WriteLine(result2);
        Console.WriteLine(number1);
        var result3 = Add4(out number1, number2);  // out yazılı yerde  dışardan değer verilmeden kullanılır  
        Console.WriteLine(result3);


        Console.WriteLine(Multiply(3, 5, 7));

        Console.WriteLine(Add4(2, 3, 4, 7, 8, 91, 15));

        Console.ReadLine();
    }
    static void Add() // void belirsiz git şu işi yap 
    {
        Console.WriteLine("Added!");
    }

    static int Add2(int number1 = 50, int number2 = 30) // default değerli parametre değişkeni number2
    {                                            // default değerler sonda olmalı
        var result = number1 + number2;
        return result;
    }
    static int Add3(ref int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }
    static int Add4(out int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    // method overloading aynı method üzerine yeni parametreler ekleme
    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2;
    }

    static int Add4(int number, params int[] numbers) // ilk gönderilen değer number değişkenine eklendi
                                                      // params en son parametredi ondan sonra değiken eklenemez  
    {
        return numbers.Sum();
    }
}
