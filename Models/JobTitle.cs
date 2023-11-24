using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_ASP.ET_Core.Models
{
    public class JobTitle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }    

        public string JobName { get; set; }

        public DateTime fileDateTime { get; set; }

        [ForeignKey("EmployeeId")]
        public required Employee Employee { get; set; }

    }
}
