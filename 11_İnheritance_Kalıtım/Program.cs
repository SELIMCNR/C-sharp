/*
 Notlar 
Class 'class' cannot have multiple base classes: 'class_1' and 'class_2' 2 class kalıtıma eklenemez  ama 
2,3,4 interface kalıtıma eklenebilir.

classların tek başına bir anlamı var 
İnterfacelerin tek başına bir anlamı yok.

Elinden geldince interface kullan
 */

//Classdan nesne oluştu
Customer customer = new Customer();
//oluşan nesneye değer atandı
customer.FirstName = "a";
//oluşan nesne yazdırıldı
Console.WriteLine(customer.FirstName);

//Classdan 3 indisli dizi oluştu 
Person[] persons = new Person[3]
{
    //dizi içerisine class objeleri ve özellik değerleri eklendi
    new Customer {FirstName = "Engin"}
    ,
    new Student {FirstName = "Derin"} 
    ,
    new Person {FirstName = "Salih"}

};

// oluşturulan dizi foreach ile yazdırıldı
foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}


//Customer classına person classında değerler inheritance kalıtım yapıldı
class Customer : Person
{
    //Ekstra özellik eklendi classa
    public string City { get; set; }

}

class Student : Person
{
    public string department { get; set; }
}