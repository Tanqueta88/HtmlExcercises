using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase3.Models;

namespace Clase3.Pages
{
    public class GameListModel : PageModel
    {
        public List<Game>? Games {get; set;}
        public void OnGet()
        {
            Games = new List<Game>();


            var game1 = new Game();
            game1.Name="Super Mario";
            game1.Clasif= Clasification.p18;
            game1.IsMultiplayer = true;

            Games.Add(game1);

            var game2 = new Game();
            game2.Name = "Moroco";
            game2.Clasif = Clasification.p18;
            game2.IsMultiplayer = true;

            Games.Add(game2);

        }
    }
}
