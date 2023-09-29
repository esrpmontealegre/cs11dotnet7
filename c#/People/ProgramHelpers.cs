using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Shared;

partial class Program
{
    static void PrintPeopleNames(IEnumerable<Person?> people,string title)
    {
        WriteLine(title);
        foreach(Person? p in people)
        {
            WriteLine(" {0}", p is null ? "<null> Person" : p.Name ?? "<null> Name");
        }
    }
}

