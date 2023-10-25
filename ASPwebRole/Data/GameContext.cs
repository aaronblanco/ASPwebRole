using ASPwebRole.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPwebRole.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<Consumable> Consumables { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<ObjectGame> ObjectGame { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Weapon> Weapons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Hero>().ToTable("Hero");
            modelBuilder.Entity<Armor>().ToTable("Armor");
            modelBuilder.Entity<Models.Attribute>().ToTable("Attribute");
            modelBuilder.Entity<Consumable>().ToTable("Consumable");
            modelBuilder.Entity<Enemy>().ToTable("Enemy");
            modelBuilder.Entity<Inventory>().ToTable("Inventory");
            modelBuilder.Entity<Map>().ToTable("Map");
            modelBuilder.Entity<ObjectGame>().ToTable("ObjectGame");
            modelBuilder.Entity<Zone>().ToTable("Zone");
            modelBuilder.Entity<Weapon>().ToTable("Weapon");
        }
    }
}