// See https://aka.ms/new-console-template for more information

using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using(ApplicationDbContext dbContext= new ApplicationDbContext())
{
    //dbContext.Database.EnsureCreated();
    if(dbContext.Database.GetPendingMigrations().Any())
    {
        dbContext.Database.Migrate();
    }
}