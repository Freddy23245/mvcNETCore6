
using EjemploWS;
using ProyectoMvc.Core;
using ProyectoMvc.Models;
using ProyectoMvc.Services.Interfaces;
using ProyectoMvc.Services.Mappers;

namespace ProyectoMvc.Services.Implementaciones
{
    public class EjemploService : IEjemploService
    {
        public List<PersonaViewModel> ObtenerPersona(string ApellidoYNombre)
        {
            var svr = new BaseService().ObtenerEjemploWS();
            var persona = svr.ObtenerPersona(ApellidoYNombre);
            return persona.Select(x => EjemploServiceMapper.MapearPersona(x)).ToList();
        }

        public PersonaViewModel RegistroPersona(PersonaViewModel nuevo)
        {
            var svr = new BaseService().ObtenerEjemploWS();
            var NuevaPersona = svr.RegistroPersona((Persona)nuevo);
            return EjemploServiceMapper.MapearPersona(NuevaPersona);
        }

        public PersonaViewModel ModificarPersona(PersonaViewModel persona)
        {
            var svr = new BaseService().ObtenerEjemploWS();
            var ModPersona = svr.ModificarPersona((Persona)persona);
            return EjemploServiceMapper.MapearPersona(ModPersona);

        }

        public PersonaViewModel EliminarPersona(PersonaViewModel persona)
        {
            var svr = new BaseService().ObtenerEjemploWS();
            var PersonaDelete = svr.EliminarPersona((Persona)persona);
            return EjemploServiceMapper.MapearPersona(PersonaDelete);
        }
    }
}
