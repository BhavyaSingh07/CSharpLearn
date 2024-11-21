string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
string msg= "";
foreach(var val in values){
    decimal num;
    if(decimal.TryParse(val, out num)){
        total+=num;
    }
    else{
        msg+=val;
    }

}
Console.WriteLine($"Num {total} + string {msg}");

