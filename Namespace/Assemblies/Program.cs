using System;
using System.Xml.Linq; //For XDocument

XDocument doc = new();

string s1 = "hi";
string s2 = "Jay";

WriteLine($"{s1} {s2}");

/* 
fdd framework dependent deployment <- deploys dll
fde framework dependent executable <- deploys cmd executable exe
self-contained <- 

#######
create new proj -> modify proj file, import system.console class -> go to program.cs -> output msg -> access environment.os ver -> open .csproj -> 
after ImplicitUsings add example: <RuntimeIdentifier>win10-x64</RuntimeIdentifier> 

->add runtimeidentifier sa propertygroup

 */
