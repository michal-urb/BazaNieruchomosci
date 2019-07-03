using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.ViewModels
{
    public class EditVM
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Pwoerzchnia")]
        public string Area { get; set; }

        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Miejscowość")]
        public string Place { get; set; }

        [Required]
        [Display(Name = "Województwo")]
        public string District { get; set; }
        /// <summary>
        /// //
        /// </summary>
        [Required]
        [Display(Name = "Okolica")]
        public string Region { get; set; }

        [Required]
        [Display(Name = "Data budowy")]
        public int YearOfBuilding { get; set; }

        [Required]
        [Display(Name = "Przeznaczenie")]
        public string Use { get; set; }

        [Required]
        [Display(Name = "Parking")]
        public bool Parking { get; set; }

        [Required]
        [Display(Name = "Liczba pokoi")]
        public int Rooms { get; set; }

        [Required]
        [Display(Name = "Piętro")]
        public int Floor { get; set; }

        [Required]
        [Display(Name = "Winda")]
        public bool Lift { get; set; }

        [Required]
        [Display(Name = "Balkon")]
        public bool Balcony { get; set; }

        [Required]
        [Display(Name = "Pow. działki")]
        public string PlotArea { get; set; }
    }
}
