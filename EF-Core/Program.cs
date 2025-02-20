using EF_Core.Context;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AppDbContext db = new AppDbContext();

            db.Database.Migrate();
        }
    }
}
