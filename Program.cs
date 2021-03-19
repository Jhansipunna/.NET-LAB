using System;
namespace ExceptionEx
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine($"square of(num)is {num * num}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error info:"+ex.Message);
            }
            finally
            {
                Console.WriteLine("re-try with adifferent number");
            }
        }
        
    }
}