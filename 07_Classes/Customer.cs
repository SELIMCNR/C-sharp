using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{
    public class Customer
    {
        public string firstName; // field 


        // Müşterinin bilgilerini özelliklerini tutar
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        // DIŞARDAN DEĞER EKLENDİĞİNDE SET BLOĞU ÇALIŞIR
        // Dışarıya değer verdiğinde get çalışır.
        public string FirstName
        {
            get { return "Mr" + firstName; } //encapsülation kapsülleme
            set { firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }



    }
}
