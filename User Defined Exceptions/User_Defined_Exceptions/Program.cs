using System;

namespace User_Defined_Exceptions
{
    public class AgeException : Exception
    {
        public AgeException(string message)
            : base(message)
        {

        }
    }
    class TestProgram
    {
        static void Valid(int age)
        {
            if (age < 18)
            {
                throw new AgeException("Sorry, Age must be greater than 18...!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Valid(17);
            }
            catch (AgeException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest of the code");
            Console.ReadLine();
        }
    }
}
