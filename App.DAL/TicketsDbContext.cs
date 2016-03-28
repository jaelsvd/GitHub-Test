using App.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
   public class TicketsDbContext:DbContext
    {
       
        public TicketsDbContext():base("TicketsDbConnName")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
