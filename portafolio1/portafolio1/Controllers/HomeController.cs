using Microsoft.AspNetCore.Mvc;
using portafolio1.Models;
using System.Diagnostics;

namespace portafolio1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos=ObtenerProyectos().Take(3).ToList();
            var modelo= new HomeIndexViewModel() { Proyectos=proyectos };


            return View(modelo);
        }
        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
             new Proyecto
             {
                 Titulo="App para certificaciones Microsoft",
                 Descripcion="Portal de entretenimiento Tecnologias Microsoft",
                 Link="https://learn.microsoft.com/es-es/certifications/",
                 ImagenURL="/imagenes/cerificaciones.jpg"
              },
             new Proyecto
             {
                Titulo="Grupo Bancolombia",
                Descripcion="Desarrollo App clientes",
                Link="https://www.bancolombia.com/personas//",
                ImagenURL="/imagenes/Bancolombia.png"

             },
             new Proyecto
             {
                 Titulo="Desarrollo App Virtual Exito",
                 Descripcion="Desarrollo App Virtual Compras Online Angular",
                 Link="https://www.exito.com//",
                 ImagenURL="/imagenes/comprasonline.jpg"
             },
             new Proyecto
             {
                 Titulo="Desarrollo App Simulador de Prestamos",
                 Descripcion="Desarrollo App de Presdtamos",
                 Link="https://WWW.bancodex.com",
                 ImagenURL="/imagenes/prestamo.jpg"
             }
            };
        }
      











        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
