using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Servises
{
    public class Proposal
    {
        [Required] //Не null
        [MaxLength(30)]
        public string First_Name { get; set; }

        [Required] //Не null
        [MaxLength(30)]
        public string Second_Name { get; set; }

        [Required] //Не null
        [MaxLength(5)]
        public int Age { get; set; }

        [Required] //Не null
        [MaxLength(100)]
        public double Height { get; set; }

        [Required] //Не null
        [MaxLength(100)]
        public double Weight { get; set; }
    }
}
