using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.entities.model
{
    public class Advisor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(50)]
        [Required]
        public string FullName { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public int CourseId { get; set; }
    }
}
