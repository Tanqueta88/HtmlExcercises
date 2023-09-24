using Clase3.Models;

namespace Clase3.Services;

public static class GameService
{
    public static List<Game> GameList {get; set;} = new List<Game>();

    public static List<Game> GetAll()
    {
        if(GameList.Count()== 0)
        {
        var gameList = new List<Game>();
        var game1 = new Game();
        game1.Name = "Super Mario";
        game1.Clasif = Clasification.p18;
        game1.IsMultiplayer = true;

        GameList.Add(game1);

        var game2 = new Game();
        game2.Name = "Moroco";
        game2.Clasif = Clasification.p18;
        game2.IsMultiplayer = true;

        GameList.Add(game2);

        var game3 = new Game();
        game2.Name = "No toca boton";
        game2.Clasif = Clasification.p18;
        game2.IsMultiplayer = true;

        GameList.Add(game2);

        }
        return GameList;
    }

    public static void Delete(string name){
        var item = GameList.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        if(item != null){
            GameList.Remove(item);
        }
    }

    public static void Create(Game newGame)
    {
        GameList.Add(newGame);

    }
    public static void Update()
    {

    }



}