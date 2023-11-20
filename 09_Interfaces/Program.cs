using _09_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {   //Interfaceler newlenemez abstraclarda newlenemez çünkü soyutlar
        // Interfacesıntro();
       //veritabanı işlemleri sqlDemoda
        SqlDemo();


        
        //Interfaceden array oluşturuldu 
        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
            new SqlServerCustomerDal(),
            new OracleServerCustomerDal(),
            new SqlServerCustomerDal(),
        };
        //oluşturulan array çalıştırıldı 
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }

    }

    private static void SqlDemo()
    {
        //Yapılan veritabanlarını ınterfaceli şekilde çalıştırma
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
        customerManager.Add(new OracleServerCustomerDal());
    }

    private static void Interfacesıntro()
    {
        PersonManager manager = new PersonManager();
        manager.Add(new Customer { Id = 1, Firstname = "Engin", Lastname = "Demiroğ", Address = "Kahramanmaraş" });


        PersonManager manager1 = new PersonManager();
        Student student = new Student
        {
            Id = 1,
            Firstname = "student",
            Lastname = "lastname",
            Department = "Computer",
        };
        
        manager1.Add(student);

        manager1.add(new Customer { Id=1,Firstname="Selim",Lastname="Çınar",Address="Kahramanmaraş" });
        Console.ReadLine();
    }
}

interface IPerson
{
    int Id { get; set; }
    string Firstname { get; set; }
    string Lastname { get; set; }
}

class Customer : IPerson  // Iperson ınterfacesinin tüm özelliklerini kullanabilir.
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Address { get; set; } // müşteriye özel durum
}
class Student : IPerson
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string Department { get; set; } //öğrenciye ait özellik
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string Department { get; set; } //işçiye ait özellik
}

class PersonManager   // Interfaceleri kullanmaya yarar
{   
    //Constructorda Customer classında olanlara ulaşılır
    public void add(Customer customer)
    {
        Console.WriteLine(customer.Firstname);
    }

    //Constructorda ınterfacede olan tüm classlara ulaşılır.
    public void Add(IPerson person)
    {
        Console.WriteLine(person.Firstname);
    }


}
