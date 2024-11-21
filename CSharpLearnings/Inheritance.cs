using System;

public abstract class Employee{
    public string Name;
    protected Employee(string name){
        Name = name;
    }
    public double Salary;
    public abstract void CalculateSalary();
    public virtual void CalculateBonus(){
        Console.WriteLine("");
    }
}

public class FullTimeEmployee:Employee{
    public FullTimeEmployee(string name):base(name){}
    public override void CalculateSalary()
    {
        Salary=10000;
        Console.WriteLine($"Salary of {Name} is {Salary}");
    }
    public override void CalculateBonus()
    {
        double bonus = Salary*2.0;
        Console.WriteLine($"The bonus for {Name} is {bonus}");
    }
}

public class ContractualEmployee:Employee{
    public ContractualEmployee(string name):base(name) {}
    public override void CalculateSalary()
    {
        Salary = 5000;
        Console.WriteLine($"Salary of contractual employee {Name} is {Salary}");
    }
}

public interface Employeemgmnt{
    void AddEmoloyee(Employee employee);
    void displayEmployee();
}

public class Manager:Employeemgmnt{
    private List<Employee> employees = new List<Employee>();
    public void AddEmoloyee(Employee employee){
        employees.Add(employee);
    }
    public void displayEmployee(){
        foreach (var employee in employees){
            employee.CalculateSalary();
            employee.CalculateBonus();
        }
    }

}

class Program{
    static void Main(){
        Manager m1 = new Manager();
        Employee e1 = new FullTimeEmployee("Aman");
        Employee e2 = new ContractualEmployee("Bhavya");

        m1.AddEmoloyee(e1);
        m1.AddEmoloyee(e2);

        m1.displayEmployee();

        //extension method - user defined, sdk based
    }
}