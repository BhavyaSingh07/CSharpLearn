string[] orders = {"B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"};

foreach(string it in orders){
    if(it.StartsWith("B")){
        Console.WriteLine(it);
    }
}

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

int saleamount = 1001;
Console.WriteLine($"Discount: {(saleamount > 1000 ? 100 : 50)}");

Random coin = new Random();
int flip = coin.Next(0,2);
Console.WriteLine((flip==0)? "heads" : "tails");