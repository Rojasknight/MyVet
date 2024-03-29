﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyVet.Web.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Display(Name = "Service Type")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        //relacion de uno a muchos con History
       public ICollection<History> Histories { get; set; }
    }

}
