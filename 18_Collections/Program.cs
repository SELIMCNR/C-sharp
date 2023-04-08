
using System.Collections;
using System.Globalization;

NedenKoleksiyonlar();

ArrayList();

Lists();

Dictionary();

Console.ReadKey();


static void ArrayList()
{

    Console.WriteLine("ArrayList");
    /*
     Koleksiyonlar ArrayList:
     ArrayList'e tip güvenli çalışma olmaz. tip güvenli çalışma ben int çalışacağım sadece int olsun demektir. ArrayListe object türünde değer alır.
     */

    ArrayList cities = new ArrayList();
    cities.Add("Ankara");
    cities.Add("Antalya");
    cities.Add(1);
    cities.Add('A');

    foreach (var city in cities)
    {
        Console.WriteLine(city);
    }
    cities.Add("İstanbul");
    Console.WriteLine(cities[2]);
}

static void NedenKoleksiyonlar()
{
    Console.WriteLine("Array");
    /*
     Günümüz projelerinde array çok kullanılmaz koleksiyonlar kullanılır sebebi bir array a olsun.
    a arrayine new dedik değer ekledi ama a arrayine bir daha new demek zorunda kaldık o anda ilk new imizde değerler bellekte kalır ama dizide kalmaz dizide 2.newimiz kalır. O yüzden koleksiyonlar kullanılır
     */


    string[] citie = new string[2] { "Ankara", "İstanbul" }; /// ilk new 
    citie = new string[3]; // ikinci newde ilk new değerleri gider arrayden. 
    citie.Contains("Ankara"); // şehirlerde ankara varmı varsa true yoksa false verir.
    Console.WriteLine(citie[0]); // Ankara değilde boş hiçbirşey gelmez. referansdan dolayı
}

static void Lists()
{
    Console.WriteLine("Listeler");
    /*Koleksiyonlar List : Tip güvenlidir genericdir.
     * <İstenendeğertipi> dışında farklı tipte örnek int gelemez.
        Gerçek hayat projelerinde class ile kullanılır. 

     */
    List<string> cities = new List<string>();
    cities.Add("Ankara");
    cities.Add("Antalya");
    cities.Add("Afyon");

    foreach (var city in cities)
    {
        Console.WriteLine(city);
    }

    //Gerçek hayat Projelerinde list class ile kullanılır.

    //ilk tanımlama şekli
    /*List<Customer> customers = new List<Customer>();
    customers.Add(new Customer { Id=1,FirstName="Selim"});
    customers.Add(new Customer { Id = 2, FirstName = "Yusuf" });*/


    //ikinci tanımlama şekli
    /*List koleksiyonu oluştur Customer tipinden ve customers obejesi oluştur ve new ile class özelliklerine ekle */
    List<Customer> customers = new List<Customer>
{
    new Customer{Id = 1 , FirstName="Selim"},
    new Customer{Id = 2 , FirstName = "Yusuf"}
};

    //ListKoleksiyonu bazı methotlar

    var count = customers.Count(); //Count : Kaç tane
    var customer1 = new Customer
    {
        Id = 3,
        FirstName = "Salih"
    };
    customers.Add(customer1); //Add: ekle
    customers.AddRange(new Customer[2]  // addRange:Array şeklinde ekle
    {
    new Customer {Id = 4 ,FirstName="Ali"},
    new Customer {Id = 5 ,FirstName = "Ayşe"}
    });


    //customers.Clear();  // Listeyi temizler.

    //Contains : İçerisinde aranan değerler var mı. Varsa True yoksa False değeri verir.
    Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Engin" }));
    Console.WriteLine(customers.Contains(new Customer { Id = 3, FirstName = "Salih" }));

    var index = customers.IndexOf(customer1); // IndexOf : Kaçıncı indexte baştan
    Console.WriteLine("İndex : {0}", index);
    var lastindex = customers.LastIndexOf(customer1); // LastIndexOf: Kaçıncı indexte sondan
    Console.WriteLine("Index : {0}", lastindex);

    customers.Insert(0, customer1); // Insert : Kaçıncı indexe neyi ekle

    customers.Remove(customer1); //remove : Bulduğu ilk değeri siler.

    customers.RemoveAll(c => c.FirstName == "Salih");   //remove all:İsmi şu olanları bul sil

    foreach (var customer in customers)
    {

        Console.WriteLine(customer.FirstName);
    }
    Console.WriteLine("Count : {0} ", count);
}

static void Dictionary()
{
    Console.WriteLine("Dictionary");
    /*Koleksiyonlar Dictionary(Sözlük): 
     * Anahtar - değer şeklinde çalışır, key-value pairing. 
     */
    //dictionary adında sözlük tanımlandı
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    //sözlüğe eklemeler yapıdlı
    dictionary.Add("book", "kitap");
    dictionary.Add("table", "tablo");
    dictionary.Add("Computer", "Bilgisayar");
    //sözlükte değer yazdırıldı anahtar yazılarak
    Console.WriteLine(dictionary["table"]);

    //sözlükte değerler döngüde yazdırıldı
    foreach (var item in dictionary)
    {
        //Anahtarları yaz
        Console.WriteLine(item.Key);
        //Değerleri yaz
        Console.WriteLine(item.Value);
        //Komple sözlük yapısını yaz
        Console.WriteLine(item);
    }
    //Ara anahtarlarda glass var mı ? 
    Console.WriteLine(dictionary.ContainsKey("glass"));
    //Ara değerlerde tablo var mı ? 
    Console.WriteLine(dictionary.ContainsValue("tablo"));

    //Class ile kullanımı
    //Classdan obje oluşturuldu
    Customer customer = new Customer();
    //keyValuePairs adlı sözlük oluşturuldu 
    Dictionary<Customer, int> keyValuePairs = new Dictionary<Customer, int>();
    //sözlüğe sınıfdan anahtarla , sınıfın özelliklerinden id'den değerler eklendi
    keyValuePairs.Add(customer, customer.Id);
    //Sözlük döngü ile yazdırıldı
    foreach (var pair in keyValuePairs)
    {
        Console.WriteLine(pair.Key);
        Console.WriteLine(pair.Value);
        Console.WriteLine(pair);
    }
}

class Customer
{
    public int Id;
    public string FirstName;
}