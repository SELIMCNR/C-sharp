using _09_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {   //Interfaceler newlenemez abstraclarda newlenemez çünkü soyutlar
        // Interfacesıntro();

        NewMethod();

        ICustomerDal[] customerDals= new ICustomerDal[3]
        {
            new SqlServerCustomerDal(),
            new OracleServerCustomerDal(),
            new SqlServerCustomerDal(),
        };
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
    }

    private static void NewMethod()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
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
    }
}

interface IPerson
{
     int Id { get; set; }
     string Firstname  { get; set; }
     string Lastname { get; set; }
}

class Customer : IPerson  // Iperson ınterfacesinin tüm özelliklerini kullanabilir.
{
    public int Id { get ; set ; }
    public string Firstname { get ; set; }
    public string Lastname { get ; set; }
    public string Address { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string Department { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string Department { get; set; }
}

class PersonManager
{
    public void Add(IPerson person) {
        Console.WriteLine(person.Firstname);
    }

   
}