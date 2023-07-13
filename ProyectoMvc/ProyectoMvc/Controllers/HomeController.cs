using Microsoft.AspNetCore.Mvc;
using ProyectoMvc.Core;
using ProyectoMvc.Core.Session;
using ProyectoMvc.Models;
using ProyectoMvc.Services.Interfaces;
using ProyectoMvc.Services.Mappers;
using System.Diagnostics;

namespace ProyectoMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEjemploService _ejemploService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISessionData _sessioData;
        public HomeController(IEjemploService ejemploService, IHttpContextAccessor httpContextAccessor,ISessionData sessionData)
        {
            _ejemploService = ejemploService;
            _httpContextAccessor = httpContextAccessor;
            _sessioData = sessionData;
        }

        public IActionResult Index( string ApellidoYNombre = null)
        {
            if (string.IsNullOrEmpty(ApellidoYNombre))
                ApellidoYNombre = null;
            var personas = _ejemploService.ObtenerPersona(ApellidoYNombre);
            _sessioData.Personas = personas;
            return View(personas);
        }

        public IActionResult Detalle(int id)
        {
            var personaSeleccionada = _sessioData.Personas.FirstOrDefault(x => x.id == id);
            return View(personaSeleccionada);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PersonaViewModel nuevo)
        {
            _ejemploService.RegistroPersona(nuevo);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ModificarPersona(PersonaViewModel persona)
        {
            _ejemploService.ModificarPersona(persona);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Eliminar(PersonaViewModel persona)
        {
            _ejemploService.EliminarPersona(persona);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            var valor = _sessioData.Personas;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}