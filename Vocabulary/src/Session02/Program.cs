/*// See https://aka.ms/new-console-template for more information

//#error version

Console.WriteLine("Hello, World!");

//sample income tax computation


multi
line
comment
 
 

var total = subtotal in between line comment + incometax;*//*


using System;
using System.Linq;
using System.Collections.Generic;




namespace Basics { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kahit ano");
            Console.WriteLine("{0:D} {1}",DateTime.Today,25.6);
        }
    }
}


*/

using System;
using System.Linq;
using System.Net.Http;
using System.Reflection;

Assembly? App = Assembly.GetEntryAssembly();

System.Data.DataSet ds;
HttpClient client;

if (App == null) return;

foreach (AssemblyName name in App.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);   

    int methodCount = 0;

    foreach(TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();
    }

    //Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",arg0:a.DefinedTypes.Count(),arg1:methodCount,arg2:name.Name);

}

double profitInpeso = 100.25;
Console.WriteLine($"variable {nameof(profitInpeso)} has value {profitInpeso}.");

string hline = new('-', count: 50);
Console.WriteLine(hline);
Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinEmoji = char.ConvertFromUtf32(0x1f600);
Console.WriteLine(grinEmoji);

string fPath = @"C:\cs11dotnet7\Vocabulary\Session02\Program.cs\ttest";//@ converts to raw string
Console.WriteLine(fPath);

string xml = """<person jay="50"> <first_name> earl </first_name> </person>""";

Console.WriteLine(xml);