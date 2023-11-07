internal class Program
{
    private static void Main(string[] args)
    {
        Intro();

        string sentence = "My name is Engin Demiroğ";

        var result = sentence.Length; // karakter uzunlunu veriri
        var result2 = sentence.Clone(); // klonlama yapar farklı değişkenoluşturulur.
        sentence = "My name is Derin Demiroğ";

        bool result3 = sentence.EndsWith("ğ"); // sonu ğ mi
        bool result4 = sentence.StartsWith("My name");  // My name ile başlıyor mu 

        var result5 = sentence.IndexOf("name"); //name kaçıncı indiste 
        var result6 = sentence.IndexOf(" "); // boşluk kaçıncı indexte
        var result7 = sentence.LastIndexOf(" "); // aramaya sondan başlar
        var result8 = sentence.Insert(0, "hello , "); // 0.indise hello ekle
        var result9 = sentence.Substring(3, 4);   //metni parçalar
        var result10 = sentence.ToLower(); // HEPSİNİ KÜÇÜK HARFE ÇEVİRİR
        var result11 = sentence.ToUpper(); // Hepsini büyük harf yapar.
        var result12 = sentence.Replace(" ", "-");  // boşluk yerine - koy   
        var result13 = sentence.Remove(2, 5);  // 2 indisten itibaren 5 tanesini sil 


        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.ReadLine();


    }

    private static void Intro()
    {
        //String metinsel veri türlerini tutar.
        //stringler char arraydir indislerle çalışır 0 ilk indis.
        string city = "Ankara";
        Console.WriteLine(city[0]);


        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        string city2 = "istanbul";
        string result = city + city2; // stringlerde toplama var.

        Console.WriteLine(result);
        // string format kullanılabilir ekstra bellek kullanılmaz
        Console.WriteLine(String.Format("{0} , {1}", city, city2));
    }
}
