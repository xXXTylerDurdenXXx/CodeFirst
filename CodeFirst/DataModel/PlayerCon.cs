using CodeFirst.DataModel;
using System;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst.DataModel
{
    public class PlayerCon : DbContext
    {
        
        public PlayerCon()
            : base("name=PlayerCon")
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

   
}