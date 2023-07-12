using EjemploWS;
using System.ComponentModel.DataAnnotations;

namespace ProyectoMvc.Models
{
    public class PersonaViewModel
    {
        public int id { get; set; }
        public string Cuil { get; set; }
        public string ApellidoYNombre { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }

        public static explicit operator Persona(PersonaViewModel model)
        {
            return new Persona
            {
                id = model.id,
                Cuil = model.Cuil,
                ApellidoYNombre = model.ApellidoYNombre,
                FechaNacimiento = model.FechaNacimiento
            };
        }
    }
}
