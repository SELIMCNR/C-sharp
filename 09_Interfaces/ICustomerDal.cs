using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces
{
    //Veri tabanında ekleme silme güncelleme işlemleri burada yapılır ICustomerDal
    interface ICustomerDal
    {
        void Add();

        void Update();
        void Delete();

    }


    //SqlServerda ICustomerDal'ı kullan 
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql adedd.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    //Oracle serverda ICustomerDal interfacesini kullan
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }


    }

    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }


    }
    //Yapılan işlemleri çalıştırır
    class CustomerManager
    {
        //Constructor oluşturuldu
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
