using EF_Core_02.Entities;
using Microsoft.EntityFrameworkCore;

namespace Revision03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            #region Navigational Property

            //var department = new List<Department>()
            //{
            //    new Department(){DeptName="HR"},
            //    new Department(){DeptName="PR"},
            //    new Department(){DeptName="IT"},
            //};

            //context.departments.AddRange(department);
            //context.SaveChanges();

            //var employess = new List<Employee>()
            //{
            //    new Employee(){Name="Ahmed Ali" , Address="Cairo" , Age=25, Salary=12000, DeptId=100},
            //     new Employee(){Name="Mahmoud Khaled" , Address="Giza" , Age=27, Salary=15000, DeptId=100},
            //      new Employee(){Name="Mostafa Ahmed" , Address="Alex" , Age=28, Salary=18000, DeptId=200},
            //       new Employee(){Name="Mariam Waleed" , Address="Luxor" , Age=28, Salary=19000, DeptId=200},
            //        new Employee(){Name="Salem Mohamed" , Address="Cairo" , Age=30, Salary=20000, DeptId=300},
            //};

            //context.employees.AddRange(employess);
            //context.SaveChanges();

            //var employee= context.employees.FirstOrDefault(E=>E.EmpId==10);

            //Console.WriteLine(employee?.EmpId??0);
            //Console.WriteLine(employee?.Name??"NA");
            //Console.WriteLine(employee?.Address??"NA");
            //Console.WriteLine(employee?.Age??0);
            //Console.WriteLine(employee?.HiringDate??DateTime.UtcNow);
            //Console.WriteLine(employee?.WorkFor.DeptName??"NA"); 
            #endregion

            #region Explicit Loading

            //var employee = context.employees.FirstOrDefault(E => E.EmpId == 1);

            //context.Entry(employee).Reference(E=>E.WorkFor).Load();

            //Console.WriteLine(employee?.EmpId ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow);
            //Console.WriteLine(employee?.WorkFor.DeptName ?? "NA");


            //var department = context.departments.FirstOrDefault(D => D.Id == 100);

            //context.Entry(department).Collection(D=>D.Employees).Load();

            //Console.WriteLine(department.DeptName);

            //foreach(var i in department.Employees)
            //{
            //    Console.WriteLine(i.Name);
            //} 
            #endregion

            #region Eager Loading
            //var employee = context.employees.Include(E=>E.WorkFor).FirstOrDefault(E => E.EmpId == 1);

            //Console.WriteLine(employee?.EmpId ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow);
            //Console.WriteLine(employee?.WorkFor.DeptName ?? "NA");


            //var department = context.departments.Include(D=>D.Employees).FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.DeptName);

            //foreach (var i in department.Employees)
            //{
            //    Console.WriteLine(i.Name);
            //} 
            #endregion

            #region Lazy Loading
            //var employee = context.employees.FirstOrDefault(E => E.EmpId == 1);

            //Console.WriteLine(employee?.EmpId ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow);
            //Console.WriteLine(employee?.WorkFor.DeptName ?? "NA");


            //var department = context.departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.DeptName);

            //foreach (var i in department.Employees)
            //{
            //    Console.WriteLine(i.Name);
            //} 
            #endregion

            #region Join Operators
            //var result = context.departments.Join(context.employees, E => E.Id, D => D.DeptId, (D, E) =>
            //new
            //{
            //    EmpId = E.EmpId,
            //    EmpName = E.Name,
            //    DeptId = D.Id,
            //    DeptName = D.DeptName
            //}).Where(D=>D.DeptName=="HR");


            //var result = from E in context.employees
            //             join D in context.departments
            //             on E.DeptId equals D.Id
            //             where D.DeptName=="HR"
            //             select new
            //             {
            //                 EmpId = E.EmpId,
            //                 EmpName = E.Name,
            //                 DeptId = D.Id,
            //                 DeptName = D.DeptName
            //             };


            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //} 
            #endregion




        }
    }
}
