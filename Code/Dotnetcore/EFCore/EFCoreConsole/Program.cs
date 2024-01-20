// See https://aka.ms/new-console-template for more information

using DataAccess.Data;
using DataModel.ModelClass;
using Microsoft.EntityFrameworkCore;

 

var db = new ApplicationDbContext();

foreach (BookView lBookView in db.lBookView.Where(x=>x.Publisher_ID==1))
{
    Console.WriteLine($"Book Publisher {lBookView.Publisher_ID}");
    Console.WriteLine($"Book Title {lBookView.BookTitle}");
    Console.WriteLine($"Book ISBN {lBookView.ISBN}");
}

 