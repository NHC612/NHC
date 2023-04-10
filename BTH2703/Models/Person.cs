using System.ComponentModel.DataAnnotations;
namespace BTH2703.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string PersonName { get; set; } //prop
        public string Address { get; set; }
    }
}