using System;

namespace Unit_Testing
{
    class Program
    {
        decimal Balance = 4000;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Seattle Bank's ATM");
                // 
                 ATMWoke();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                Console.WriteLine("Have a nice day!");
            }

           


        }

       static void ATMWoke()
        {
            try
            {


                Console.WriteLine("Please select one of the following:");
                Console.WriteLine("1 - View Balance");
                Console.WriteLine("2 - Withdraw Money");
                Console.WriteLine("3 - Deposit Money");
                Console.WriteLine("4 - Exit ");
               

                // still need to fix things //
               // static void viewBalance()
                {

                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
        }
       



    }
}
