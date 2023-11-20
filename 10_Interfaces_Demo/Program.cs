internal class Program
{


    //Solid prensipleri araştır
    //Interfaceyi iyi kullanma prensibi
    private static void Main(string[] args)
    {

        //İnterfacelerden dizi 
        IWorker[] workers = new IWorker[3]
        {
            new Manager(),
            
            new Worker(),
            new Robot(),
        };
        //Dizide değerler foreach döngüsünde
        foreach (var worker in workers)
        {
            //Ekrana yazılacak değerler
            worker.Work();
        }

        //İnterfaceden dizi
        IEat[] eats = new IEat[2]
        {
            new Worker(),
            new Manager(),
         //interfaceyi implement etmedinden new Robot(),
        };

        foreach (var eat in eats) {
            eat.Eat();
        }


    
    }

    //IWorker adlı interface oluşturuldu
    interface IWorker
    {
        void Work();
    }
   
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    //Classla interface arasında inheritance kalıtım sağlandı
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek yendi ");
        }

        public void GetSalary()
        {
            Console.WriteLine("Para harcandı");
        }

        public void Work()
        {
            Console.WriteLine("İş yapıldı");
        }
    }

    //Farklı interfaceler classa kalıtım yoluyla eklendi
    class Worker : IWorker,IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek yendi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Para harcandı");
        }

        public void Work()
        {
            Console.WriteLine("İş yapıldı");
        }
    }

    class Robot : IWorker
    {
        
        public void Work()
        {
            Console.WriteLine("İş yapıldı");
        }
    }


}
