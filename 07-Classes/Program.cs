using _07_Classes;

internal class Program
{
    private static void Main(string[] args)
    {
      // class gruplamada kullanılır metotlarla beraber çalışır 
      //Property özellikleri de tutabilir
      CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

      ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();    
    
    //Customer clasında özelliklere değerler eklendi
      Customer customer= new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Selim";
        customer.LastName = "Çınar";

        Customer customer2 = new Customer
        {
            Id = 2,City = "İstanbul",FirstName = "Selim",LastName="Çınar"
        };
        
        Console.WriteLine(customer2.FirstName);
        Console.WriteLine(customer2.LastName);

    }
}
class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }
    public void Update()
    {
        Console.WriteLine("Customer updated!");
    }
}

