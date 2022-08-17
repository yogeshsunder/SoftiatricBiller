using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Softiaric.Database
{
    public class BilerContext:DbContext
    {
        ConfigurationManager ConfigurationManager { get; set; }
        public BilerContext(DbContextOptions<BilerContext> options):base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Suppiler> Suppilers { get; set; }

        public DbSet<Addresss> Address { get; set; }

        
            

    }

}
