using OWL_Teams.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OWL_Teams.DAL
{
    public class TeamContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}