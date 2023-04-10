using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTH2703.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public Guid StudentID { get; set;}
        public string StudentCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
