using Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            find();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }

        //method hali action delegasyonu
        HandleException(() =>
        {
            find(); //Action parametresi karşılığı
        });


      
        //action delegasyonu
        exceptionİntro();
        Console.ReadLine();
    }

    private static void HandleException(Action action)
    {
        try
        {
            action.Invoke(); // actionda işlemi yap
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
            throw;
        }
        
    }

    private static void find()
    {
        List<string> list = new List<string> { "isim1", "isim2" };
        if (!list.Contains("isim11"))
        {
            throw new RecordNotFoundException("Record found!");
        }
        else
        {
            Console.WriteLine("Record found!");
        }
    }

    private static void exceptionİntro()
    {
        /*try dene hata olursa catche yaz*/
        try
        {

            string[] students = new string[] {
        "a","b","c"
        };

            students[3] = "1";
            Console.WriteLine("Exception");
        }
        catch (IndexOutOfRangeException ex)
        {
            //Index fazlası
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            //Bölme hatası
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException);
        }
    }
}