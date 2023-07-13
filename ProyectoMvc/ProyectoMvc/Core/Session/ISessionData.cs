using ProyectoMvc.Models;

namespace ProyectoMvc.Core.Session
{
    public interface ISessionData
    {
        List<PersonaViewModel> Personas { get;set; }
        string ValorString { get;set; }
    }
}
