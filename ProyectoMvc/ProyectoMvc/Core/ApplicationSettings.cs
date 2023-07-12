namespace ProyectoMvc.Core
{
    public class ApplicationSettings
    {
        public static string? URLEjemploWS { get; set; }
        public static bool EsDesarrollo { get; set; }
        public static void ApplicationConfig()
        {
            URLEjemploWS = Environment.GetEnvironmentVariable("URLWebService");
            EsDesarrollo = Environment.GetEnvironmentVariable("EsDesarrollo").ToString() == "1";
        }

    }
}
