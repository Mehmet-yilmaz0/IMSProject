using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.entities.model
{
    public class SelectedCourse
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public bool IsApproved { get; set; }
    }
}
