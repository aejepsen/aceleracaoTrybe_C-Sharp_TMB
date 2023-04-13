using Xunit;
using System;
using FluentAssertions;
using TrybeGames;
using Moq;

namespace TrybeGames.Test;

[Collection("Sequential")]
public class TestTrybeGamesDatabase
{
    [Theory(DisplayName = "Deve testar se GetGamesPlayedBy retorna jogos jogados pela pessoa jogadora corretamente.")]
    [MemberData(nameof(DataTestGetGamesPlayedBy))]
    public void TestGetGamesPlayedBy(TrybeGamesDatabase databaseEntry, int playerIdEntry, List<Game> expected)
    {

        var players = databaseEntry.Players.Where(p => p.Id == playerIdEntry).ToList();              

        var playerAdd = new List<Player>();

        foreach (var player in players)
        {
            playerAdd.Add(new Player
            {
                Id = player.Id,
                Name = player.Name,
                GamesOwned = player.GamesOwned
            });
        }

        databaseEntry.GetGamesPlayedBy(playerAdd[0]).Should().BeEquivalentTo(expected);

    }

    public static TheoryData<TrybeGamesDatabase, int, List<Game>> DataTestGetGamesPlayedBy => new TheoryData<TrybeGamesDatabase, int, List<Game>>
    {
        {
            new TrybeGamesDatabase
            {
                Games = new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "Teste",
                        DeveloperStudio = 1,
                        Players = new List<int> { 1 }
                    }
                },
                GameStudios = new List<GameStudio>
                {
                    new GameStudio
                    {
                        Id = 1,
                        Name = "Teste"
                    }
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Teste",
                        GamesOwned = new List<int> { 1 }
                    }
                }
            },
            1,
            new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Teste",
                    DeveloperStudio = 1,
                    Players = new List<int> { 1 }
                }
            }
        }
    };

    [Theory(DisplayName = "Deve testar se GetGamesOwnedBy retorna jogos da pessoa jogadora corretamente.")]
    [MemberData(nameof(DataTestGetGamesOwnedBy))]
    public void TestGetGamesOwnedBy(TrybeGamesDatabase databaseEntry, int playerIdEntry, List<Game> expected)
    {
        // testar se GetGamesOwnedBy retorna jogos da pessoa jogadora corretamente
        var players = databaseEntry.Players.Where(p => p.Id == playerIdEntry).ToList();
        var ownner = new List<Player>();
        foreach (var player in players)
        {
            ownner.Add(new Player
            {
                Id = player.Id,
                Name = player.Name,
                GamesOwned = player.GamesOwned
            });
        }
        databaseEntry.GetGamesOwnedBy(ownner[0]).Should().BeEquivalentTo(expected);
    }

    public static TheoryData<TrybeGamesDatabase, int, List<Game>> DataTestGetGamesOwnedBy => new TheoryData<TrybeGamesDatabase, int, List<Game>>
    {
        {
            new TrybeGamesDatabase
            {
                Games = new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "Teste",
                        DeveloperStudio = 1,
                        Players = new List<int> { 1 }
                    }
                },
                GameStudios = new List<GameStudio>
                {
                    new GameStudio
                    {
                        Id = 1,
                        Name = "Teste"
                    }
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Teste",
                        GamesOwned = new List<int> { 1 }
                    }
                }
            },
            1,
            new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Teste",
                    DeveloperStudio = 1,
                    Players = new List<int> { 1 }
                }
            }
        }
    };

    [Theory(DisplayName = "Deve testar se GetGamesDevelopedBy retorna jogos desenvolvidos pelo estúdio corretamente.")]
    [MemberData(nameof(DataTestGetGamesDevelopedBy))]
    public void TestGetGamesDevelopedBy(TrybeGamesDatabase databaseEntry, int gameStudioIdEntry, List<Game> expected)
    {
        var gameStudios = databaseEntry.GameStudios.Where(gs => gs.Id == gameStudioIdEntry).ToList();
        var gameStudioAdd = new List<GameStudio>();
        foreach (var gameStudio in gameStudios)
        {
            gameStudioAdd.Add(new GameStudio
            {
                Id = gameStudio.Id,
                Name = gameStudio.Name
            });
        }
        databaseEntry.GetGamesDevelopedBy(gameStudioAdd[0]).Should().BeEquivalentTo(expected);
    }

    public static TheoryData<TrybeGamesDatabase, int, List<Game>> DataTestGetGamesDevelopedBy => new TheoryData<TrybeGamesDatabase, int, List<Game>>
    {
        {
            new TrybeGamesDatabase
            {
                Games = new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "Teste",
                        DeveloperStudio = 1,
                        Players = new List<int> { 1 }
                    }
                },
                GameStudios = new List<GameStudio>
                {
                    new GameStudio
                    {
                        Id = 1,
                        Name = "Teste"
                    }
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Teste",
                        GamesOwned = new List<int> { 1 }
                    }
                }
            },
            1,
            new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Teste",
                    DeveloperStudio = 1,
                    Players = new List<int> { 1 }
                }
            }
        }
    };
}
