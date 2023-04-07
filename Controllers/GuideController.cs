using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebTele.Models;

namespace WebTele.Controllers
{
    public class GuideController : Controller
    {
        private readonly ILogger<GuideController> _logger;

        public GuideController(ILogger<GuideController> logger)
        {
            _logger = logger;
        }

        public IActionResult DISNEY()
        {
            ViewData["Programs"] = GetProgramsDisney();

            return View();
        }

        private List<Models.Program> GetProgramsDisney()
        {
            var programs = new List<Models.Program>();

            programs.Add(new Models.Program("Mickey Mouse", "Aventuras del icónico personaje de Disney y sus amigos", "mickey-mouse.jpg"));
            programs.Add(new Models.Program("Vampirina", "Historias de una familia de vampiros que se muda a Pensilvania", "vampirina.jpg"));
            programs.Add(new Models.Program("Muppet Babies", "Aventuras de los famosos Muppets en versión bebé", "muppet-babies.webp"));
            programs.Add(new Models.Program("La casa de Mickey Mouse", "Aventuras de Mickey y sus amigos en la Casa Club", "casa-mickey.jpg"));
            programs.Add(new Models.Program("Puppy Dog Pals", "Aventuras de dos cachorros que resuelven problemas", "puppy-dog-pals.jpg"));
            programs.Add(new Models.Program("PJ Masks", "Aventuras de tres niños que se convierten en héroes por la noche", "pj-masks.jpg"));
            programs.Add(new Models.Program("El maravilloso mundo de Mickey", "Serie de cortometrajes de Mickey y sus amigos", "mundo-mickey.jpeg"));
            programs.Add(new Models.Program("Fancy Nancy", "Historias de una niña que ama la moda y la creatividad", "fancy-nancy.jpg"));
            programs.Add(new Models.Program("Bluey", "Aventuras de una familia de perros en su día a día", "bluey.jpeg"));

            return programs;
        }

        public IActionResult CARTOON()
        {
            ViewData["Programs"] = GetProgramsCartoon();

            return View();
        }

        private List<Models.Program> GetProgramsCartoon()
        {
            var programs = new List<Models.Program>();

            programs.Add(new Models.Program("Hora de Aventuras", "Las aventuras de Finn y Jake en el mundo post-apocalíptico de Ooo", "hora-de-aventuras.webp"));
            programs.Add(new Models.Program("El increíble mundo de Gumball", "Las aventuras cotidianas de Gumball y su familia", "gumball.jpg"));
            programs.Add(new Models.Program("Teen Titans Go!", "Las divertidas aventuras de los superhéroes adolescentes", "teen-titans-go.jpg"));
            programs.Add(new Models.Program("Steven Universe", "La historia de Steven, un niño mitad humano y mitad gema", "steen-universe.jpg"));
            programs.Add(new Models.Program("Victor y Valentino", "Dos hermanos que viven en un pueblo mágico en México", "victor-valentino.jpg"));
            programs.Add(new Models.Program("We Bare Bears", "Las aventuras de tres osos que intentan adaptarse a la vida humana", "we-bare-bears.jpg"));
            programs.Add(new Models.Program("El show de Tom y Jerry", "Las divertidas travesuras del gato y el ratón en situaciones hilarantes, ingeniosas y a menudo caóticas.", "tom-jerry-show.webp"));
            programs.Add(new Models.Program("Ben 10", "Las aventuras de Ben y su reloj Omnitrix que le permite transformarse en diferentes alienígenas", "ben-10.png"));
            programs.Add(new Models.Program("Mao Mao: Héroes de puro corazón", "Las aventuras de un valiente samurái y sus amigos en el Valle Corazón", "mao-mao.jpg"));

            return programs;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
