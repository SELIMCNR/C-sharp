/*Virtual :  İnheritance kalıtım edilmiş sınıfta  farklı işlem yapmayı sağlar override yaz virtual metodu seç işlemi değiştir.
  override: üzerine yaz demek .
  base: Ana classı Database classını çalıştır.
 */

Database database = new Database();
database.Add();



class Database
{

    public virtual void Add()
    {
        Console.WriteLine("Added by default.");
    }
    public virtual void Delete() 
    {
        Console.WriteLine("Deleted by default");
    }

}

class SqlServer : Database
{
    //Farklı işlemlerde virtual ile override yazıp istenen değer elde edilebilir.
    public override void Add()
    {
        Console.WriteLine("Added by sql code");
        base.Add(); //Database içerisinde Add kodu çalışır
    }
}

class MySqlServer : Database
{
    
}
