var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (!app.Environment.IsDevelopment()) 
{
    app.UseHsts();

}

app.UseHttpsRedirection();

app.UseDefaultFiles();//should come before static files
app.UseStaticFiles();

app.MapGet("/hello", () => "Hello World!");

app.Run();

//t
WriteLine("This executes after web server stops.");