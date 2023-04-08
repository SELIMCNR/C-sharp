/*
 
 Constructor :  Sınıf newlendiği anda çalışacak kod bloğudur. 
 
 Constructor oluşturma kısayol ctor yaz taba bas oluşsun classın içinde

Sayfalama işlemlerinde kullanılır. 
 */


//Clastan customerManager adlı obje nesne oluştu.
CustomerManager customerManager = new CustomerManager(10);
customerManager.List();

Product product = new Product { Id = 1, Name = "laptop" }; //classda değerlere özelliklere ekleme
Product product2 = new Product(2,"Computer"); //parametreli constructora ekleme
Product product3 = new Product(); //parametresiz constructor


//Classdan yeni obje türetildi ve constructor parametresine hangi classın çalıştırılacağı yazıldı
EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());

EmployeeManager employeeManager2 = new EmployeeManager(new FileLogger());


//PersonManager classından personManager adlı nesne oluştu ve parametreli constructora değeri  yazıldı
PersonManager personManager = new PersonManager("Product");
//objenin metodu çalıştırıldı
personManager.Add();

/*Staticler newlenemez . Static classa static olamayan özellik ve method eklenemez , Normal classa static method eklenebilir normal method da eklenir*/

Teacher.Number = 10;

Utilities.Validate();

Manager.DoSomething(); // static method

Manager manager = new Manager();
manager.DoSomething2(); // static olmayan method


Console.ReadKey();




// Class adı CustomerManager
class CustomerManager
{

    private int _count=20;
    //Classa ait parametreli Constructor 
    public CustomerManager(int count)
    {
        //Constructora özellik eklendi
        _count = count; 
    }

    //Classa ait parametresiz Constructor ikiside kullanılabilir.
    public CustomerManager()
    {
        
    }

    //Clasa ait methotlar
    public void List()
    {
        //Constructorda değer methoda yazdırıldı
        Console.WriteLine("Listed {0}  items",_count);
    }
    public void Add() {

        Console.WriteLine("Added");
    }
}

class Product
{
    //Parametresiz Constructor
    public Product()
    {
        
    }

    private int _id;
    private string _name;
    //Parametreli constructor
    public Product(int id, string name)
    {
        _id = id;

        _name = name;

    }

    // class ait özellikler
    public int Id { get; set; }
    public string Name { get; set; }

}

//Interface tanımlandı ILogger adında
interface ILogger
{
    //Interfaceye Log adlı method eklendi
    void Log();
}

//DataBaseLogger classı ILogger'dan  inheritance kalıtım yaptı
class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to data base ");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file");
    }
}

//Class oluşturuldu EmployeeManager adında
class EmployeeManager
{
    //Interface değişkene eşitlendi
    private ILogger _logger;

    //Classın Constructoru ınterfaceyi parametre olarak aldı
    public EmployeeManager(ILogger logger)
    {
        //Parametre ve ınterface değişkeni eşitlendi
        _logger = logger; 
    }


    // Add adında method eklendi
    public void Add()
    {
        //Interface içerisinde log methodu çalıştırıldı 
        _logger.Log();
        Console.WriteLine("Added!");

    }
}

//Class oluşturuldu
class BaseClass
{
    //classa ait özellik eklendi
    private string _entity;
    //classa ait parametreli constructor eklendi
    public  BaseClass(string entity)
    {
        _entity = entity;

    }
    //classa ait mesaj eklendi
    public void Message()
    {
        Console.WriteLine("{0} message",_entity);
    }
}

//PersonManager classı BaseClass'dan inherit kalıtım yaptı
class PersonManager : BaseClass
{
    //PersonManager constructoru BaseClass constructoruna değer gönderdi
    public PersonManager(string entity) : base(entity)
    {

    }
    // Add methodu eklendi ve 
    public void Add()
    {
        Console.WriteLine("Added ! ");
        //BaseClassa ait Message methodu çalıştırıldı
        Message();
    }
}

/*Static classlar newlenemez ve static clas içerisindeki özellikler , methodlarda static olmak zorundadır
 İş yap bitir işlemlerinde kullanılır
 */
static class Teacher
{
    public static int Number { get; set; }

}

static class Utilities
{
    /*Static parametresiz constructor*/
    static Utilities()
    {
        
    }
    public static void Validate()
    {
        Console.WriteLine("Validation is done .");
    }
}

/*Class içerisinde staticlerde newlenemez. */
class Manager
{
    public static void DoSomething()
    {
        Console.WriteLine("Done");
    }
    public  void DoSomething2()
    {
        Console.WriteLine("Done 2");
    }
}

/*Single Design patterns bak araştır  */
