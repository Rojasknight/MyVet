using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Race { get; set; }

        //public Owner Owner { get; set; }

        

        [Display(Name = "Born")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }

        

        //TODO: replace the correct URL for the image
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://TDB.azurewebsites.net{ImageUrl.Substring(1)}";


        [Display(Name = "Date*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BornLocal => Born.ToLocalTime();

        //Relacion de uno a muchos con PetType
        public PetType PetType { get; set; }


        //Relacion de uno a mucho con Owner
        public Owner Owner { get; set; }

       //Relacion de uno a muchos con History 
        public ICollection<History> Histories { get; set; }

        //Relacion de uno a muchos con Agenda
        public ICollection<Agenda> Agendas { get; set; }
    }
}
