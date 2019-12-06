using OWL_Teams.Models;
using System.Data.Entity;

namespace OWL_Teams.DAL
{
    public class TeamContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}