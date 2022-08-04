using System;

namespace Try_and_Catch
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = 5;
    //        int b = 0;
    //        int x = a / b;
    //        Console.WriteLine(x);
    //        Console.ReadLine();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = 0;
                int x = a / b;
                Console.WriteLine(x);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest of the Code...!");
            Console.ReadLine();
        }
    }
}
