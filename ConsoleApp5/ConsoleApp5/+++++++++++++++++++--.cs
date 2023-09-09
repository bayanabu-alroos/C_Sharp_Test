namespace Bank{
    class BankAccount
    {
        public BankAccount()
        {
            Console.WriteLine("Bank account is created");
        }

        public string AccountNumber { get; set; }
        public string AccountCurrency { get; set; }
        public decimal Balance { get; set; }

    }
}

namespace Client
{
    class Person
    {
        public Person()
        {
        }

        public string PersonId { get; set; }

        public string PersonName { get; set; }
        public string[] AccountNumber { get; set; }
        public void CreateBankAccont()
        {
            Console.WriteLine("Creating new bank account ");
        }
    }
}

namespace ParentNamespace
{
    class ParentNamespeceClass
    {
        public ParentNamespeceClass()
        {
            Console.WriteLine("Parent Namespace Class Constructor is called");
        }
    }
    namespace NestedNamespace
    {
        class NestedNamespeceClass
        {
            public NestedNamespeceClass()
            {
                Console.WriteLine("Neasted Namespace Class Constructor is called");
            }
        }
    }
}