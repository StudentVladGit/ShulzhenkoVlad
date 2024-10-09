using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.Servises
{
    public class ProposalMaterial
    {
        [Required] //Не null
        [MaxLength(100)]
        public string Item_name { get; set; } //Название предмета

        [Required] //Не null
        [MaxLength(100)]
        public int Number { get; set; } //Количество

        [Required] //Не null
        [MaxLength(100)]
        public double Length { get; set; } //Длина

        [Required] //Не null
        [MaxLength(100)]
        public double Width { get; set; } //Ширина

        [Required] //Не null
        [MaxLength(100)]
        public double Height { get; set; } //Высота
    }
}
