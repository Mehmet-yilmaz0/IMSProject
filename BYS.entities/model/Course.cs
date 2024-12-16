using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.entities.model
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public int AdvisorId { get; set; }
        public bool Obligation { get; set; }
        [Range(0,5)]
        public int Credit { get; set; }
        public int Size { get; set; }
        public int RemainingSize { get; set; }
    }
}
