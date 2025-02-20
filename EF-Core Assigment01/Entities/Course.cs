using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assigment01.Entities
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("CourseName", TypeName = "varchar(100)")]
        public string Name { get; set; }

        public double Duration { get; set; }

        [Range(20,150)]
        public string Description { get; set; }

        [Required]
        public int TopId { get; set; }
    }
}
