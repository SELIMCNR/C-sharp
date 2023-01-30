internal class Program
{
    private static void Main(string[] args)
    {
        string student1 = "Engin";
        string student2 = "Derin";
        string student3 = "Salih";

        //Array tanımı 
        string[] students = new string[3];
        //arraye değer atama
        students[0] = "Engin";
        students[1] = "Derin";
        students[2] = "Salih";
        //arrayda dolaşım
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }



        //Array tanım ve değer atama 2 
        string[] students2 = { "Engin", "Derin", "Salih" };
        //students2[3] = "Ahmet";// hata verir uygulama çünkü 3.indiste eleman yok

        // arrayda dolaşım2 
        foreach (var student in students2)
        {
            Console.WriteLine(student);
        }




        //Çok boyutlu diziler
        string[,] regions = new string[5, 3] // [5satır,3sütun]
        {
                { "İstanbul","İzmit","Balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                {"Antalya","Mersin","İskenderun" },
                {"Rize","Trabzon","Samsun" },
                { "İzmir","Muğla","Manisa"},

        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("*********");
        }


        // 2.Ornek
        string[,] books = new string[4, 2]
        {
                {"Html","Css" },
                {"C","C++" },
                {"Java","C#" },
                {"Javascript","SQL" },
        };

        for (int i = 0; i <= books.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= books.GetUpperBound(1); j++)
            {
                Console.WriteLine(books[i, j]);
            }
            Console.WriteLine("********");
        }



        Console.WriteLine();
        Console.ReadLine(); //ekranı bekletmeye yarar
    }
}