/*
 
 Değer tipler: Değer tiplerde olay ilk verilen değerler üzerinden ele alınır. Bellekte sadece değerini tutan yer vardır.
 Referans tipler: Classlar, interfaceler,abstract sınıflar,stringler ve arrayler. 
 Bellek te 2 farklı yer oluşur değerini tutan yer ve referansını tutan yer
 
 
 */

//Değer tip
using System.Data;

int number1 = 10;
int number2 = 20;
number2 = number1; // number 2 20 olur  işlem burada biter.
number1 = 30; // number 1 30 olur 
Console.WriteLine(number2); // number 2 20 yazılırı

//Referans tipler
string[] cities1 = new string[] { "Ankara", "Afyon" }; // referans 101 
string[] cities2 = new string[] { "Bursa", "Bolu" }; // referansı 102 

cities2 = cities1;  // şuanda referansları 101 oldu , 102 refereansı garbıradge çöp toplayıcı özelliği sayesinde silindi .net tarafından.
cities1[0] = "İstanbul"; //cities 1 ve cities 2 de istanbul olur çünkü ikisininde refereansı 101 
Console.WriteLine(cities2[0]);

// Newlemek belleği büyük miktarda artırır.
DataTable dataTable = new DataTable();
DataTable dataTable2 = new DataTable();
dataTable2 = dataTable;




Console.ReadKey();
