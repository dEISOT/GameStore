using GameAchieves.Models;
using System;
using System.Threading.Tasks;

namespace GameAchieves.Repositories.Contracts
{
    public interface IGameRepository
    {
        Task<Game> GetAsync(Guid Id);
    }
}
