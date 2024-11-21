using System.Xml.XPath;

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}

string revsen(string sen){
    string res="";
    string[] words= sen.Split(' ');
    foreach(string word in words){
        res+=ReverseWord(word) + " ";
    }
    return res.Trim();
}
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(revsen(input));

Console.WriteLine("Hello World");
int y = 5;
void PrintValue()
{
    int y = 10;
    Console.WriteLine(y);
}
PrintValue();
