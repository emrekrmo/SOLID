using System;

namespace SingleResponsibilityPrinciple
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; } // Adres bilgisinin burada iþi olmaz
        public int ZipCode { get; set; } // Adres bilgisinin burada iþi olmaz
        public string City{get;set; } // Adres bilgisinin burada iþi olmaz
        public Guid AccountId {get;set;}
        public string Password {get;set;} // Login bilgisi de burada gereksiz
        public string Username {get;set; } // Login bilgisi de burada gereksiz

        // Metodlar proplarla ayný yerde olmamalý
        public void ChangePassword(string newPassword) => Console.WriteLine($"Changed password to {newPassword}");
        public void ChangeAddress(string street, int zipCode, string city) => Console.WriteLine("Changed address");
        public string GetAccountHolderFirstName(Guid accountNumber) => this.FirstName;
        public string GetAccountHolderLastName(Guid accountNumber) => this.LastName;
        public void DepositMoney(decimal amount) => Console.WriteLine($"{amount} has been deposited to {this.AccountId}");
        public void WithdrawMoney(decimal amount) => Console.WriteLine($"{amount} has been withdrawn from {this.AccountId}");
        public void Login(string username, string password) => Console.WriteLine($"{username} has tried to log in.");
        public void Logout(string username) => Console.WriteLine($"{username} has tried to log out.");
    }
}