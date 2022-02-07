﻿using System;

public interface IAccount
{
    void PayInFunds(decimal amount);
    bool WithdrawFunds(decimal amount);
    decimal GetBalance();
    AccountState GetState();
    string GetName();
}


//enumerated types - a type with a number of states
// made public when adding interface
public enum AccountState
{
    New,
    Active,
    UnderAudit,
    Frozen,
    Closed
}




public class CustomerAccount : IAccount
{
    // encapsulation - stop change from being made to member
    private string name;
    private AccountState state;
    private decimal balance;

    private static decimal interestRateCharged = 0.1M;


    //-------------------------------------

    public bool SetName(string inName)
    {
        if (inName == "")
            return false;

        name = inName;

        return true;
    }

    public bool SetAccountState(AccountState inState)
    {
        if (inState == AccountState.Frozen)
            return false;

        state = inState;

        return true;
    }

    const decimal MAX_BALANCE = 10000000;
    const decimal MIN_BALANCE = -10000000;

    public bool SetBalance(decimal inBalance)
    {
        if (inBalance < MIN_BALANCE ||
            inBalance > MAX_BALANCE)
            return false;

        balance = inBalance;
        return true;
    }

    // constructors
    public CustomerAccount(string inName, AccountState inState, decimal inBalance)
    {
        string errorMessage = "";

        if (SetBalance(inBalance) == false)
            errorMessage = errorMessage + "Bad Balance: " + inBalance;

        if (SetName(inName) == false)
        {
            errorMessage = errorMessage + "Bad Name: " + inName;
        }

        if (SetAccountState(inState) == false)
        {
            errorMessage = errorMessage + " Bad State : " + inState;
        }

        if (errorMessage != "")
        {
            throw new Exception("Account construction failed "
                + errorMessage);
        }
    }

    // only wanted to have balance as a parameter for testing
    public CustomerAccount(decimal inBalance) :
     this("", AccountState.UnderAudit, inBalance)
    {
    }

    // use of this for method overloading, as above
    public CustomerAccount(string inName, AccountState inState) :
     this(inName, inState, 0)
    {
    }


    // public - code running outside the class can make calls to that method
    public virtual bool WithdrawFunds(decimal amount)
    {
        if (balance < amount)
        {
            return false;
        }
        balance = balance - amount;
        return true;
    }

    public void PayInFunds(decimal amount)
    {
        balance = balance + amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public string GetName()
    {
        return name;
    }

    public AccountState GetState()
    {
        return state;
    }

    public static decimal GetInterest()
    {
        return interestRateCharged;
    }


    // Account Allowed Method
    private static decimal minIncome = 10000;
    private static int minAge = 18;
    public static bool AccountAllowed(decimal income, int age)
    {
        if ((income >= minIncome) && (age >= minAge))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class BabyAccount : CustomerAccount, IAccount
{
    public BabyAccount (string inName, AccountState inState, decimal inBalance) 
        :base(inName, inState, inBalance)
    { 
    }
    public override bool WithdrawFunds(decimal amount)
       
    {
        decimal tempBalance = GetBalance();
        Console.WriteLine("test here");
        if (amount > 10)
        {
            return false;
        }
        //if (tempBalance < amount)
        //{
        //    return false;
        //}
        SetBalance(tempBalance - amount);
        //PayInFunds(GetBalance() - amount);
        return true;
    }
}



class BankProgram
{
    // method with parameter of class type
    public static void PrintAccount(IAccount a)
    {
        Console.WriteLine("Name: " + a.GetName());
        Console.WriteLine("Account state: " + a.GetState());
        Console.WriteLine("Balance: " + a.GetBalance());
        Console.WriteLine();
    }



    public static void Main()
    {
        // check account allowed
        if (CustomerAccount.AccountAllowed(50000, 21))
        {
            Console.WriteLine("Account Allowed");
        }
        else
        {
            Console.WriteLine("Account Not Allowed");
        }

        Console.WriteLine("Interest Rate Charged: " + CustomerAccount.GetInterest());


        Console.WriteLine("----------------");


        const int MAX_CUST = 100;

        // declare an array of type Account
        IAccount[] Accounts = new IAccount[MAX_CUST];

        // access and populate fields in rows of array
        Accounts[0] = new CustomerAccount("Rob", AccountState.New, 1000000);
        PrintAccount(Accounts[0]);

        Accounts[1] = new CustomerAccount("Jim", AccountState.Active, 23);
        PrintAccount(Accounts[1]);

        Accounts[2] = new CustomerAccount("Julie", AccountState.Active);
        PrintAccount(Accounts[2]);
        
        Accounts[3] = new BabyAccount("Baby Driver", AccountState.New, 20);
        PrintAccount(Accounts[3]);


        // withdraw from Robs account
        Accounts[0].WithdrawFunds(999999);
        Console.WriteLine($"{Accounts[0].GetName()}'s balance is now {Accounts[0].GetBalance()}");

        // withdraw from Baby's account
        Accounts[2].WithdrawFunds(5);
        Console.WriteLine($"{Accounts[3].GetName()}'s balance is now {Accounts[3].GetBalance()}");

        Console.WriteLine("----------------");

        // Run test
        CustomerAccount test = new CustomerAccount(0);
        test.PayInFunds(50);
        if (test.GetBalance() != 50)
        {
            Console.WriteLine("Pay In test failed");
        }
        else
        {
            Console.WriteLine("Pay In test succeeded");
        }

    }


}