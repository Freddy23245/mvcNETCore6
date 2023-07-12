namespace ProyectoMvc.Services.Implementaciones
{
    public class Utils
    {
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            return edad;
        }
    }
}
