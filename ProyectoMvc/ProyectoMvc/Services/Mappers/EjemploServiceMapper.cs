using ProyectoMvc.Models;

namespace ProyectoMvc.Services.Mappers
{
    public static class EjemploServiceMapper
    {
        public static PersonaViewModel MapearPersona(EjemploWS.Persona data)
        {
            return new PersonaViewModel
            {
                id = data.id,
                Cuil = data.Cuil,
                ApellidoYNombre = data.ApellidoYNombre,
                FechaNacimiento = data.FechaNacimiento
            };
        }

    }
}
