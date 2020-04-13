using SportApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportApp.Context
{
    public class AdminContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}