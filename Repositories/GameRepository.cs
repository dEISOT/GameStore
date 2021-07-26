using GameAchieves.Models;
using GameAchieves.Repositories.Contracts;
using System;
using System.Threading.Tasks;

namespace GameAchieves.Repositories
{
    public class GameRepository : IGameRepository
    {
        public async Task<Game> GetAsync(Guid Id)
        {
            return new Game()
            {
                Name = "Minecraft",
                Price = 0.55
            };
        }

    }
}