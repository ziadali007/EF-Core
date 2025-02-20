using Microsoft.EntityFrameworkCore;
namespace EF_Core_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using AppDbContext db = new AppDbContext();

            //db.Database.Migrate();
            #region Create

            //var employee=new Employee()
            //{
            //    Name="Ahmed Ali",
            //    Salary=12000,
            //    Age=25,
            //    Email= "AhmedAli@gmail.com",
            //    DateOfCreation=DateTime.Now,
            //};

            //Console.WriteLine(db.Entry(employee).State);
            //db.Employees.Add(employee);

            //Console.WriteLine(db.Entry(employee).State);

            //var res = db.SaveChanges();

            //Console.WriteLine(db.Entry(employee).State);
            //Console.WriteLine(res);

            //employee.Name = "Omar";

            //Console.WriteLine(db.Entry(employee).State);
            //Console.WriteLine(res);

            //db.Employees.Add(employee);
            //res =db.SaveChanges();

            //Console.WriteLine(db.Entry(employee).State);
            //Console.WriteLine(res);

            //Console.WriteLine(db.Entry(employee).State);
            //db.Entry(employee).State = EntityState.Added;
            //Console.WriteLine(db.Entry(employee).State);
            //res = db.SaveChanges();

            #endregion

            #region Retrieve
            //var result=db.Employees.Where(E=>E.EmpId==40).FirstOrDefault();

            //var result = db.Employees.FirstOrDefault(E => E.EmpId == 2);

            //Console.WriteLine(result?.Name);

            //Console.WriteLine(db.Entry(result).State);

            //result.Name = "Omar Ali";

            //Console.WriteLine(db.Entry(result).State);

            //db.SaveChanges();

            //var result=db.Employees.Select(e => e.Name);

            //foreach (var e in result)
            //{

            //    Console.WriteLine(e);

            //} 
            #endregion

            #region Update
            //var result = db.Employees.FirstOrDefault(E => E.EmpId == 3);

            //Console.WriteLine(db.Entry(result).State);

            ////result.Name = "Mariam Waheed";

            //db.Update(result);

            //Console.WriteLine(db.Entry(result).State);

            //db.SaveChanges();

            //Console.WriteLine(db.Entry(result).State); 
            #endregion






        }
    }
}
