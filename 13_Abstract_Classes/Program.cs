/*
 AbstractClasses : Soyut sınıflar , interfaceler ile virtual methodslar arasındadır diye düşünülür.
   İçi dolu olmayan virtual methoddur.

  AbstractClasslar interfaceler gibi newlenemez.
You cannot create an instance of an abstract class or an interface. For more information, see Interfaces. hata kodu newlenmenin
 */

Database database = new SqlServer();
database.Add();
database.Delete();


Database database2 = new SqlServer();
database2.Add();
database2.Delete();



Console.ReadKey();

abstract class Database
{
    public void Add()
    {
        Console.WriteLine("Added by defaul.");
    }

    //Delete işlemi farklı olacak dedi abstract
    public abstract void Delete();
}

class SqlServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by Sql");
    }
}
class Oracle : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by Oracle");
    }
}
