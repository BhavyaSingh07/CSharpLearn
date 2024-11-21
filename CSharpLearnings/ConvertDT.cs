using System.Reflection.Metadata;

String? readresult;
string validres="";
int num=0;
bool valid;
Console.WriteLine("Enter an integer value between 5 and 10");


do{
    readresult=Console.ReadLine();
    if(readresult!=null){
        validres=readresult;
    }

    valid=int.TryParse(validres, out num);

    if(valid==true){
        if(num<=5||num>=10){
            valid=false;
            Console.WriteLine($"You entered {num}. Please enter a number between 5 and 10.");

        }
    }
    else{
            Console.WriteLine("Sorry, you entered an invalid number, please try again");

        }

}while(valid==false);
Console.WriteLine($"Your input value ({num}) has been accepted.");