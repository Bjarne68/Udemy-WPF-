using CSharpePractise.Classes;
using CSharpePractise.Interfaces;
using static CSharpePractise.Classes.BankAccount;

namespace CSharpePractise
{
    internal class Program
    {
        static double numberTwo = 12.34;
        static void Main(string[] args)
        {
           
            ChildBankaccount bankAccount = new ChildBankaccount();
            bankAccount.AddToBalance(100);

            SimpleMath simpleMath = new SimpleMath();


            Console.WriteLine(Information(bankAccount));
        }

        private static string Information(IInformation information)
        {
            return information.GetInformation();
        }
    }
}