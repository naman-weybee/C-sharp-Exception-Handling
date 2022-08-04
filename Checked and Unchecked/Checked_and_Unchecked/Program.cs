using System;

namespace Checked_and_Unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = int.MaxValue;
            Console.WriteLine(val + 2);
            Console.ReadLine();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        checked
    //        {
    //            int val = int.MaxValue;
    //            Console.WriteLine(val + 2);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        unchecked
    //        {
    //            int val = int.MaxValue;
    //            Console.WriteLine(val + 2);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
