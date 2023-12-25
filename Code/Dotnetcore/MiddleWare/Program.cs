using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();


app.Map("/a", app1 =>
{

    app1.Use(async (Context,next) =>
    {
        Context.Response.WriteAsync("This Routting a Context from use method");
        next.Invoke();
    });
    app1.Run(async Context =>
    {
        Context.Response.WriteAsync("Map 1 a Routing");
    });
});
app.Use(async (Context, next) =>
{
    await Context.Response.WriteAsync("Started Use 1\n");
    next.Invoke();
    await Context.Response.WriteAsync(" End Use 1\n");
});


app.Use(async (Context, next) =>
{
    await Context.Response.WriteAsync("Started Use 2\n");
    next.Invoke();
    await Context.Response.WriteAsync(" End Use 2\n");
});

// Run is used to handle the single delegator

app.Run(async Context=>
{
    await Context.Response.WriteAsync("Hello This is my first context Line");
});
 
app.Run();
