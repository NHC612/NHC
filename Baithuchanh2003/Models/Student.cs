using System.ComponentModel.DataAnnotations;
namespace Baithuchanh2003.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; } //prop
        public string Address { get; set; }
    }
}