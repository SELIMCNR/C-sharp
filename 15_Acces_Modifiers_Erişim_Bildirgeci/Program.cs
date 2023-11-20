/*Erişim bildirgeçleri
 Private gizli: Sadece bulunduğu classta okunur
Protected: inherit edildiği sınıflarda da kullanılabilir claslla beraber.
Internal: Bağlı bulunan proje assembly içerisinde kullanılır.
Public: Heryerden ulaşılabilir demek.
 */

Customer customer1 = new Customer();
customer1.Save();




class Customer
{
    public int id5;
    protected int id4;
    protected int id3;
    private int id2;
    int id; // Private bir değişkendi id
    public void Save()
    {
        id = 1;
        id2= 2;
    }
    public void Delete()
    {
        id--;
        id2--;
    }
}

class Student : Customer
{
    public void Save()
    {
        id4++;
        Customer customer = new Customer();
        
    }
}

class Course  // default modifiers internaldır classlarda classlar ya internal ya public olur. Private ve protected olmaz.
{
    private class nestedClass
    {
        // İç içe classlarda private olur sadece

    }
    public string Name { get; set; }

}
