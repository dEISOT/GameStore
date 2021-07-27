using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameAchieves.Models
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Purchase> Purchases { get; set; }


    }

    public class GameDbInitializer : DropCreateDatabaseAlways<GameContext>
    {

        protected override void Seed(GameContext db)
        {
            db.Games.Add(new Game { Name = "Battlefield1", Company = "Dice", Price = 19.99 });
            db.Games.Add(new Game { Name = "Battlefield2", Company = "Dice", Price = 19.99 });
            db.Games.Add(new Game { Name = "Battlefield3", Company = "Dice", Price = 19.99 });
        }
    }
}