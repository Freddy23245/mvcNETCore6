using ProyectoMvc.Models;

namespace ProyectoMvc.Services.Interfaces
{
    public interface IEjemploService
    {
        List<PersonaViewModel> ObtenerPersona(string ApellidoYNombre);
        PersonaViewModel RegistroPersona(PersonaViewModel nuevo);
        PersonaViewModel ModificarPersona(PersonaViewModel persona);
        PersonaViewModel EliminarPersona(PersonaViewModel persona);
    }
}
