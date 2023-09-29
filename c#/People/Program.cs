using Class.Shared;

Person jay = new () { Name = "Jay", Birthday = new (year: 1995, month: 08, day: 03) };
//jay.ConsoleWrite();

/*System.Collections.Hashtable lookUpObject = new();
lookUpObject.Add(key: 1, value: "alpha");
lookUpObject.Add(key: 2, value: "beta");
lookUpObject.Add(key: 3, value: "gamma");

lookUpObject.Add(key: jay, value: "delta");*/

//int key = 2;

//WriteLine(format:"key {0} has value: {1}", arg0: key, arg1: lookUpObject[key]);
//WriteLine(format: "key {0} has value: {1}", arg0: jay, arg1: lookUpObject[jay]);

Dictionary<int, string> lookUpIntString = new(); // allows for compiler type checking
lookUpIntString.Add(key: 1, value: "alpha");
lookUpIntString.Add(key: 2, value: "beta");
lookUpIntString.Add(key: 3, value: "gamma");
lookUpIntString.Add(key: 4, value: "delta");

int key = 3;

WriteLine(format: "key {0} has value: {1}", arg0: key, arg1: lookUpIntString[key]);

Person p1 = new();
int ans = p1.MethodIWannaCall("frog");


DelegateWithMatchingSign d = new(p1.MethodIWannaCall);
int ans2 = d("frog");

WriteLine(ans2);

//jay.ShoutOut = Jay_shout;

//assign EventHandler methods to ShoutOut event
jay.ShoutOut += Jay_shout;
jay.ShoutOut += Jay_shout2;


jay.Kalabet();
jay.Kalabet();
jay.Kalabet();
jay.Kalabet();



Person?[] people =
{
    null,
    new () {Name = "JP"},
    new () {Name = "Earl"},
    new () {Name = "Jay"},
    new () {Name = null},
    new () {Name = "Ako"}
};

PrintPeopleNames(people, "MIT");
Array.Sort(people);
PrintPeopleNames(people, "Post sort using person's IComparable implem");


Array.Sort(people, new PersonComparer());
PrintPeopleNames(people, "Post sort using person's IComparer implem");

delegate int DelegateWithMatchingSign(string s);
//object? sender 
//EventArgs e or TEventArgs e <- relevant info sa nangyayareng event
//for methods na di kailangan ng additional arg values to be passed in:
//public delegate void EventHandler(object? sender, EventArgs e);

//for methods that need additional arg values passed in as defined by generic type TEventArgs
//public delegate void EventHandler<TEventArgs>(object? sender, EventArgs e);



/*
namespace System
{
    public interface IComparable
    {
        int CompareTo(object? obj);//works with nullable object type
    }

    public interface IComparable<in T>
    {
        int CompareTo(T?obj);//nullable generic type T
    }


}*/

//this calls both implicit and explicit implementations of Lose 
Person p = new();
p.Lose(); //calls implicit implem of losing a key

((IGamePlayer)p).Lose(); //calls explicit implem of losing a game

IGamePlayer player = p as IGamePlayer;
player.Lose();//calls explicit implem of losing a game


public interface IGamePlayer
{
    void Lose();

}

public interface IKeyHolder
{
    void Lose();
}

public class Person:IGamePlayer, IKeyHolder
{
    //Implicit implementation
    void Lose() 
    {
        //Implement losing a key

    }

    //Explicit implementation
    void IGamePlayer.Lose()
    {
        //Implement losing a game
    }
}




