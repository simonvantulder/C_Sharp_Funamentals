using System.ComponentModel.DataAnnotations;
namespace ThankGod4Kaitlyn.Models
{
    public class Survey
    {
        [Required]
        [MinLength(3)]
        public string Name {get;set;}

        [Required]
        [MinLength(3)]
        public string Location {get;set;}

        [Required]
        [MinLength(1)]
        public string Language {get;set;}

        [MinLength(8)]
        public string Comment {get;set;}
    }
}
