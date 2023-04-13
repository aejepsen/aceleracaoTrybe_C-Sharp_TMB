namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        // retornar uma lista com todos os jogos desenvolvidos por um estúdio
        return Games.Where(g => g.DeveloperStudio == gameStudio.Id).ToList();

    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        // retorna uma lista com todos os jogos jogados por um jogador (player) específicado por seu id (player.Id)
        return Games.Where(g => g.Players.Contains(player.Id)).ToList();
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        // retornar uma lista com todos os jogos comprados por um jogador (player) específicado por seu id (player.Id)
        return Games.Where(g => g.Players.Contains(playerEntry.Id)).ToList();
    }

  public object GetGamesDevelopedBy(int gameStudioIdEntry)
  {
    throw new NotImplementedException();
  }
}
