using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WeakNinja;
using StrongNinja;
using RPG;//todo: rearrange into one solution file
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",async(HttpContext context) =>
    { 
        //create actors
        var target = new Ninja("Recca", new Sword(), new Pistol());
        var ninja = new Ninja("Naruto",new Sword(), new Shuriken());
        await Logic.ExecuteSequenceAsync(ninja, target, writeAsync:s => context.Response.WriteAsync(s));
        
    }   
);

app.MapGet("/old", async (HttpContext context) =>
{
    //create actors
    var target = new Ninja("Recca", new Sword(), new Shuriken());
    var ninja = new Ninja("Naruto", new Sword(), new Shuriken());
    await Logic.ExecuteSequenceAsync(ninja, target, writeAsync: s => context.Response.WriteAsync(s));

}
);

app.Run();

public class Weapon { }

public class Sword:Weapon { }

public class TwoHandedSword:Sword { }


[Fact]

public void Covariance_Test()
{
    Assert.isType<Sword>(Covariance());
    Assert.Throws<InvalidCastException>(() => BreakCovariance());
}

private Weapon Covariance() => new Sword();//pwedeng ireturn yung sword into a weapon kasi subtype siya
private TwoHandedSword BreakCovariance() => (TwoHandedSword) new Sword();//eto yung hindi pwede, you cannot return the super type as a subtype

//covariance -> pwedeng i output yung instance
//contravariance -> 


[Fact]

public void Contravariance_Test()
{
    Contravariance(new Sword());//we can pass a sword as a weapon
    BreakContravariance(new Weapon());//cannot pass weapon as a sword

}

private void Contravariance(Weapon weapon) { }
private void BreakContravariance(Weapon weapon) { }


//ISP :
//more smaller client specific interfaces is better than generalized interfaces
//NO 1 interface to rule them all
public class Library:ILibFinder,ILibCRUD { };

public interface ILibrary 
{ 
    IEnumerable<Book> Books { get; }
    Book? Find(int bookID);

    void Create(Book book);
    void Update(Book book);
    void Delete(Book book);

};
//alternate implementation that follows ISP:
//ILibFinder {IEnumerable<Book> Books { get; } Book? Find(int bookID);} <- ISP implem
//ILibCRUD {void Create(Book book);void Update(Book book);void Delete(Book book);} 


namespace DIP.Core;
public class Librarian
{
    private IlibFinder _bookFinder;

    public Librarian(ILibFinder bookFinder)
    {
        _bookFinder = bookFinder;
    }

    public Task<IEnumerable <Book>> FindMultiple()
    {
        return Task.FromResult(_bookFinder Book);
    }

    public Task<Book?> Find(int bookID)
    {
        var book = _bookFinder.Find(bookID);
        return Task.FromResult(book);
    }

}

//###############//

private class Admin
{
    private static Library Library = new();

    public Librarian Curate()
    {
        return new Librarian(bookFinder: Library);
    }
}

