using System;
using System.Collections.Generic;
using System.Text;


namespace CustomException
{
    public class IntegerStException : Exception
    {
        public IntegerStException(string message) : base(message)
        {

        }
    }

    public class IntegerStringException
    {


        static void Main(string[] args)
        {
            IntegerStringException i = new IntegerStringException();
            Console.WriteLine("Enter a Number : ");
            try
            {

                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The number is : " + n);
            }
            catch (Exception e)
            {
                Console.Write("It is in String Format!" + e.Message);
            }
        }
    }
}