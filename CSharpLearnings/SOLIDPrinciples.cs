class Account{
    private string accountNumber;
    protected double balance;
    public string accountHolderName;

    public Account(string accountNumber, double balance, string accountHolderName){
        this.accountNumber=accountNumber;
        this.balance=balance;
        this.accountHolderName=accountHolderName;
    }

    public string getAccountNumber(){
        return accountNumber;
    }

    protected void adjustBalance(double amount){
        balance+=amount;
    }
}

interface ITransactionaccount{
    void Deposit(double amount);
    void Withdraw(double amount);

    //string getAccountNumber();
}

interface Iinteresaccount{
    void addInterest(double rate);
}

class fixedDeposit: Account, Iinteresaccount{
        public fixedDeposit(string accountNumber, double balance, string accountHolderName) : base(accountNumber,balance,accountHolderName){}

        public void addInterest(double rate){
            adjustBalance(balance*rate);
        }
}

class savingsAccount: Account, ITransactionaccount{
    public savingsAccount(string accountNumber, double balance, string accountHolderName) : base(accountNumber,balance,accountHolderName){}

    public void Deposit(double amount){
        adjustBalance(amount);
        Console.WriteLine($"Deposited {amount} into account");
        Console.WriteLine($"The new balance is {balance}");
    }

    public void Withdraw(double amount){
        if(balance>= amount){
            adjustBalance(-amount);
            Console.WriteLine($"{amount} withdrawn from account");
            Console.WriteLine($"The new balance is {balance}");

        }
        else{
            Console.WriteLine("Not enough money in account");
        }
    }
}

class currentAccount: Account, ITransactionaccount{
        public currentAccount(string accountNumber, double balance, string accountHolderName) : base(accountNumber,balance,accountHolderName){}

        public void Deposit(double amount){
        adjustBalance(amount);
        Console.WriteLine($"Deposited {amount} into account");
        Console.WriteLine($"The new balance is {balance}");
    }

    public void Withdraw(double amount){
        if(balance>= amount){
            adjustBalance(-amount);
            Console.WriteLine($"{amount} withdrawn from account");
            Console.WriteLine($"The new balance is {balance}");
        }
        else{
            Console.WriteLine("Not enough money in account");
        }
    }

}

class Banking{
    static void Main(){
        ITransactionaccount s1 = new savingsAccount("12345", 10000, "Bhavya");
        s1.Deposit(5600);
        s1.Withdraw(500);

        Iinteresaccount s2 = new fixedDeposit("54321", 9000, "Aman");
        s2.addInterest(8.5);

    }
}


public interface Ilogger{
   void log(string message);
}

public class fileLogger:Ilogger{
    public void log(string msg){
        Console.WriteLine($"The file {msg} has been implemented");
    }
}

public class Access{
    Ilogger logger;
    public Access(Ilogger logger){
        this.logger = logger;
    }

    public void addMember(string name){
        logger.log(" Member added: " + name);
    }
}

class Mainprog{
        static void Main(){
            Ilogger l1 = new fileLogger();
            Access aone = new Access(l1);
            aone.addMember("Bhavya");

        }
}