using Demo.Shared;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddShopeeContext();
//controllers,endpointapiexplorer,swaggergenerator instead of razor pages <-for api

var app = builder.Build();

if (!app.Environment.IsDevelopment()) 
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();//should come before static files
app.UseStaticFiles();

app.MapRazorPages();
//map controllers,endpointapiexplorer,swaggergenerator instead of razor pages <-for api

app.MapGet("/hello", () => "Hello World!");

app.Run();

//t
WriteLine("This executes after web server stops.");