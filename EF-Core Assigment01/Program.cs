using EF_Core_Assigment01.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Assigment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AppDbContext context = new AppDbContext();

            context.Database.Migrate();
        }
    }
}
