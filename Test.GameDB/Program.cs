using Game.DB.Lib;
using Game.Model;

using (GamesDB db = new GamesDB())
{
    db.TableGames.Add(new Games
    {
        Name = "Diablo",
        Company = "Blizzard",
        Style = "RPG",
        Release = new DateTime(2007,12,06),
    });

    db.TableGames.Add(new Games
    {
        Name = "StarCraft",
        Company = "Blizzard",
        Style = "Strategy",
        Release = new DateTime(1996,11,07)
    });

    db.SaveChanges();

    Console.WriteLine("Данные сохранены");

    Console.WriteLine("\nИнформация о играх:\n");

    foreach(var game in db.TableGames)
    {
        Console.WriteLine($"#{game.Id}  {game.Name}  {game.Company}  {game.Style}  {game.Release.ToString("d")}");
    }
}
