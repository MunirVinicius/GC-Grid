using Microsoft.AspNetCore.Mvc;
using grandchase.Models;

namespace grandchase.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index(){
            var model = Character.CreateCharacters();
            return View(model);
        }
    }
}