//constructor - where are they used
class Example{
    public int number;
    public string name;
    public static string StaticField;

    public Example(){
        number = 0;
        name = "Bhavya";
        Console.WriteLine("Default contructor invoked");
    }

    public Example(int number, string name){
        this.number=number;
        this.name=name;
        Console.WriteLine("Parameterized contructor invoked");
    }

    public Example(Example other){
        number=other.number;
        name=other.name;
        Console.WriteLine("Copy contructor invoked");

    }

    static Example(){
        StaticField = "Initialized by static constructor";
        Console.WriteLine("static constructor called");
    }

    private Example(bool flag){
        Console.WriteLine("Private constrcutor called");
    }

    public static Example CreateInstanceWithPrivate(){
        return new Example(true);
    }

    public Example(string name): this(42,name){
        Console.WriteLine("Chained constructor called");
    }

    public void Display(){
        Console.WriteLine($"Number: {number}, Name: {name}");
    }
}

class Prog{
    static void Main(){
        Example obj1 = new Example();
        obj1.Display();

        Example obj2 = new Example(10, "John");
        obj2.Display();

        Example obj3 = new Example(obj2);
        obj3.Display();

        Console.WriteLine($"StaticField: {Example.StaticField}");

        Example obj4 = Example.CreateInstanceWithPrivate();
        

        Example obj5 = new Example("Alice");
        obj5.Display();
    }
}
