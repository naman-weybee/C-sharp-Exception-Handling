using System;

namespace SystemException_class
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 10;
            }
            catch(SystemException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
