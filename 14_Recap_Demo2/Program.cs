/*
 Profesyonel Soyutlama
Best practislerle
Database ile dosya ile sms ile loglamalar farklı olur
 */

//Logger classından logger adlı obje nesne oluşturduk
DatabaseLogger logger = new DatabaseLogger();
//Nesneden log adlı methodu çağırdık.
logger.Log();
//ve Ekrana yazdırdık
Console.WriteLine("Customer added!");

//CustomerManager classından yeni nesne oluştu
CustomerManager customerManager = new CustomerManager();
//Oluşan nesne Logger özelliği ile FileLogger classından newlendi
customerManager.Logger = new FileLogger();
//customerManagerdeki add methodu çalıştırıldı
customerManager.Logger = new SmsLogger();
customerManager.Add();

Console.ReadKey();

//class oluşturuduk CustomerManager adında
class CustomerManager
{
    //ILogger interfacesinden Logger adlı özellik eklendi
    public ILogger Logger { get; set; }

    //Add adlı method oluşturduk.
    public void Add()
    {
        //Logger interfacesinde log methodu çalıştırıldı
        Logger.Log();
        Console.WriteLine("Customer added!");
    }
}

    //DatabaseLogger classı ILogger interfacesinden kalıtım aldı ve logu ekrana yazdırdı.
class DatabaseLogger:ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database!");
    }
}

//FileLogger classı ILogger interfacesinden kalıtım aldı ve logu ekrana yazdırdı
class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file ! ");
    }
}

class SmsLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to sms !");
    }
}

//ILogger adlı interface ve Log methodu içerisinde mevcut
interface ILogger
{
    void  Log();
}

