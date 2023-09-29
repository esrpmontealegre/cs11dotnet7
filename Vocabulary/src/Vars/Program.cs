/*object height = 1.7;
dynamic name = "Earl";

Console.WriteLine($"{name} is {height}m tall");

//name = 12;

name = new[]{2,4,6};


int len1 = name.Length;

//int len2 = ((string)name).Length;

Console.WriteLine($"{name} has {len1} chars.");

//memory for value type are released
//for reference, it waits for garbage collection
*/

using System.Xml;


/*
var int pop = 110_000_000;
var double wt = 75.2;
var decimal price = 20.5M;
var string fruit = "mango";
var char lt = 'W';
var bool mad = false;
*/

var xml1 = new XmlDocument(); //good use of var
XmlDocument xml2 = new XmlDocument();

var f1 = File.CreateText("test.txt"); // bad use of var
StreamWriter f2 = File.CreateText("test2.txt");

//use var only when type is obvious

XmlDocument xml3 = new();

Person earl = new();
earl.BirthDate = new(1996, 7, 15);


/*
List<Person> people = new()
{
    new(){ FirstName = "Alice"},
    new(){ FirstName = "Bob" },
    new(){ FirstName = "Charlie"}
};*/

Console.WriteLine($"{default(int)}");
Console.WriteLine($"{default(bool)}");
Console.WriteLine($"{default(DateTime)}");
Console.WriteLine($"{default(string)}");

int number = 13;
Console.WriteLine(number);
number = default;
Console.WriteLine(number);




class Person
{
    public DateTime BirthDate;
};

