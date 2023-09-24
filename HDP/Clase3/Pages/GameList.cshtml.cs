using System.Reflection;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase3.Models;
using Clase3.Services;

namespace Clase3.Pages
{
    public class GameListModel : PageModel
    {
        public List<Game>? Games {get; set;}
        [BindProperty]
        public Game NewGame {get; set;}
        public void OnGet()
        {
            Games = GameService.GetAll();
            // Games = new List<Game>();


            // var game1 = new Game();
            // game1.Name="Super Mario";
            // game1.Clasif= Clasification.p18;
            // game1.IsMultiplayer = true;

            // Games.Add(game1);

            // var game2 = new Game();
            // game2.Name = "Moroco";
            // game2.Clasif = Clasification.p18;
            // game2.IsMultiplayer = true;

            // Games.Add(game2);

        }
        public IActionResult OnPost(){
            var newObject = NewGame;
            GameService.Create(newObject);

            return RedirectToAction("get");
        }

        public IActionResult OnDelete(string name){
            GameService.Delete(name);
            return RedirectToAction("get");
        }
    }
}
