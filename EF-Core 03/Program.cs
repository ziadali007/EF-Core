using EF_Core_03.Contexts;
using EF_Core_03.Entities;

namespace EF_Core_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();

            //FullTimeEmployee FullTime01 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Age = 25,
            //    Address = "Cairo",
            //    Email = "AhmedA774@gmail.com",
            //    Salary = 12000

            //};

            //FullTimeEmployee FullTime02 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Mohamed",
            //    Age = 27,
            //    Address = "Giza",
            //    Email = "AhmedM774@gmail.com",
            //    Salary = 15000

            //};

            //FullTimeEmployee FullTime03 = new FullTimeEmployee()
            //{
            //    Name = "Mariam Ahmed",
            //    Age = 25,
            //    Address = "Alex",
            //    Email = "MariamA554@gmail.com",
            //    Salary = 15000

            //};

            //db.FullTimeEmployees.Add(FullTime01);
            //db.FullTimeEmployees.Add(FullTime02);
            //db.FullTimeEmployees.Add(FullTime03);

            //db.SaveChanges();

            //PartTimeEmployee FullTime01 = new PartTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Age = 25,
            //    Address = "Cairo",
            //    Email = "AhmedA774@gmail.com",
            //    NumberOfHours = 50,
            //    HourRate = 60

            //};

            //PartTimeEmployee FullTime02 = new PartTimeEmployee()
            //{
            //    Name = "Ahmed Mohamed",
            //    Age = 27,
            //    Address = "Giza",
            //    Email = "AhmedM774@gmail.com",
            //    NumberOfHours = 55,
            //    HourRate = 65

            //};

            //PartTimeEmployee FullTime03 = new PartTimeEmployee()
            //{
            //    Name = "Mariam Ahmed",
            //    Age = 25,
            //    Address = "Alex",
            //    Email = "MariamA554@gmail.com",
            //    NumberOfHours = 50,
            //    HourRate = 66
            //};

            //db.PartTimeEmployees.Add(FullTime01);
            //db.PartTimeEmployees.Add(FullTime02);
            //db.PartTimeEmployees.Add(FullTime03);

            //db.SaveChanges();

            //var result = db.Employees.OfType<FullTimeEmployee>();

            //foreach (FullTimeEmployee employee in result)
            //{
            //    Console.WriteLine(employee.Name);
            //}

            //foreach(var result in db.FullTimeEmployees)
            //{
            //    Console.WriteLine(result.Name);
            //}

        }
    }
}
