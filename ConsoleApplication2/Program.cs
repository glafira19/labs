using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SampleProgram
{

    class InvalidTransaction : Exception
    {
        public InvalidTransaction(string message)
            : base(message)
        {

        }

    }
    class Account
    {
        private int _balance;
        public int Balance
        {
            get
            {
                return _balance;
            }
        }
        public Account(int initialCash)
        {

            _balance = initialCash;
        }
        public void AddMoney(int amount, int transactionID)
        {

            if (Transaction.CheckID(transactionID))
                _balance += amount;
            else
                throw new InvalidTransaction("Wrong transaction ID");
        }


    }
    class Client
    {
        public string Name { get; set; }
        private Account _account;
        public Account Account
        {
            get
            {
                return _account;
            }
        }

        public Client(string name, int initialCash)
        {
            Name = name;
            _account = new Account (initialCash);
        }

        public override string ToString()
        {
            return Name + " (" + _account.Balance + ")";
        }

    }


    public class Transaction
    {

        public static bool CheckID(int id)
        {

            return id % 2 != 0;
        }
    }


    public class Application
    {


        public static void Main()
        {

            Client client = new Client("Johnny Smith", 200);

            Console.WriteLine("Начальное состояние:  " + client);

            try
            {
                client.Account.AddMoney(100, 1);
                client.Account.AddMoney(140, 2);
            }

            catch (InvalidTransaction)
            {
                Console.WriteLine("Перечисление денег было отклонено");
            }

            finally
            {
                Console.WriteLine("Конечное состояние клиента: " + client);
            }
            Console.ReadKey();
        }
    }
}

