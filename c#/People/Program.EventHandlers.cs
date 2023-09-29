using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Shared;

partial class Program
{
    //method to handle shout event received by jay object
    static void Jay_shout(object? sender, EventArgs e)
    {
        if (sender == null) return;
        Person? p = sender as Person;

        if (p == null) return;

        WriteLine($"{p.Name} is this angry: {p.angerLevel}");
    }
    //another method to handle shoutout event received by jay object
    static void Jay_shout2(object? sender, EventArgs e)
    {
        if (sender == null) return;
        Person? p = sender as Person;

        if (p == null) return;

        WriteLine($"*Death stare*");
    }
}
