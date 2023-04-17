using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTH2703.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public Guid StudentID { get; set;}
        public string StudentName { get; set; }
       
        public string Address { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FaculltyID")]
        public Faculty? Faculty { get; set; }
    }
}
