using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    //internal class Employee
    //{
    //    public int Id { get; set; }

    //    public string Name { get; set; }


    //    public int Age { get; set; }


    //    public string Email { get; set; }


    //    public DateTime DateOfCreation { get; set; }



    //}



    //internal class Employee
    //{
    //    [Key]

    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName", TypeName = "varchar(100)")]
    //    [MaxLength(50)]
    //    [StringLength(50,MinimumLength = 10)]
    //    public string Name { get; set; }


    //    [Range(20,60)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }


    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public int PhoneNumber { get; set; }


    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }


    //    [NotMapped]
    //    public double TotalSalary{ get; set; }


    //    public String Password { get; set; }




    //}


    internal class Employees
    {
        public int EmpId { get; set; }

        public string Name { get; set; }


        public int? Age { get; set; }


        public string Email { get; set; }


        public double Salary { get; set; }


        public DateTime DateOfCreation { get; set; }



    }

}
