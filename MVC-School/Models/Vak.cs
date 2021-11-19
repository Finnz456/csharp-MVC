using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_School.Models
{
    public class Vak
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string Naam { get; set; }

        [ForeignKey("Docent")]
        [Display(Name = "Docent")]
        public int DocentId { get; set; }

        public virtual Docent Docent { get; set; }
    }
}
