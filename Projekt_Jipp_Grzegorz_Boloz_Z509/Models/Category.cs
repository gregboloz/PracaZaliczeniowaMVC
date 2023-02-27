using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projekt_Jipp_Grzegorz_Boloz_Z509.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Film genre")]
        public string Name {get; set;}
        [DisplayName("No. of films by genre")]
        [Range(1,1000,ErrorMessage = "Max number of films per genre in the blockbuster store is 1000!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set;} = DateTime.Now;
    }
    
}
