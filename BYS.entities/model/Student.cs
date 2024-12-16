using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.entities.model
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [StringLength(50)]
        [Required]
        public string FullName { get; set; }
        [Range(0, 2, ErrorMessage = "sayi aralik hatasi")]
        public int OptionalCourse { get; set; } = 0;
        [Range(0, 5, ErrorMessage = "sayi aralik hatasi")]
        public int MandatoryCourse { get; set; } = 0;
        public int AdvisorId { get; set; }
    }
}