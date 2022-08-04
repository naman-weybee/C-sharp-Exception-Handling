using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
                Console.WriteLine(x);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally Block is Executed...!");
            }
            Console.WriteLine("Rest of the Code...!");
            Console.ReadLine();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            int a = 10;
    //            int b = 0;
    //            int x = a / b;
    //            Console.WriteLine(x);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Finally Block is Executed...!");
    //        }
    //        Console.WriteLine("Rest of the Code...!");
    //        Console.ReadLine();
    //    }
    //}
}
