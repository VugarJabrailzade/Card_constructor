// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Contracts;
using System.Net.Sockets;
using System.Reflection.Emit;

namespace BankAccount
{
    public class Bank
    {
        public string Fullname { get; private set; }
        public string BankName { get; set; }
        public string Code16 { get; set; }
        public string CVV { get; set; }
        public string ExpirationDate { get; set; }
        public decimal Balance { get; set; }

        public Bank(string Fullname, string BankName, string Code16, string CVV, string ExpirationDate, decimal balance)
        {
            this.Fullname = Fullname;
            this.BankName = BankName;
            this.Code16 = Code16;
            this.CVV = CVV;
            this.ExpirationDate = ExpirationDate;
            this.Balance = balance;

        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0) return;
            if (amount < Balance)
            {
                Balance -= amount;
            }

        }

        class Program
        {
            public static void Main(string[] args)
            {
                Bank NewInfo = new Bank("Vugar Jabrailzade", "Unibank", "4542 5356 1223 1220", "100", "06/2023", 500m);

                NewInfo.Fullname = "hello";
                NewInfo.Deposit(100m);
                NewInfo.Withdraw(100);
                

                Console.WriteLine(NewInfo.Fullname);
                Console.WriteLine(NewInfo.BankName);
                Console.WriteLine(NewInfo.Code16);
                Console.WriteLine(NewInfo.CVV);
                Console.WriteLine(NewInfo.ExpirationDate);
                Console.WriteLine(NewInfo.Balance);


               



            }



        }
    }
}