using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using WeakNinja;
using RPG;//todo: rearrange into one solution file
namespace WeakNinja;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",async (HttpContext context) => 
    { 
        //create actors
        var target = new Ninja("Recca");
        var ninja = new Ninja("Naruto");

//
        await Logic.ExecuteSequenceAsync(ninja, target, writeAsync:s => context.Response.WriteAsync(s));
        

    }   


);

app.Run();
