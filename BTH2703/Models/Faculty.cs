using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTH2703.Models
{
    
    public class Faculty
    {
        [Key]
       public string FacultyID { get; set; }
        public string FacultyName { get; set; }
    }
}

  
