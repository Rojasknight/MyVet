using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        //Relacion con el modelo de usuario que provee Entity
        public User User { get; set; }

        //Relacion de uno a muchos con Pet
        public ICollection<Pet> Pets { get; set; }

        //Relacion de uno a muchos con Agenda
        public ICollection<Agenda> Agendas{ get; set; }

    }
}
