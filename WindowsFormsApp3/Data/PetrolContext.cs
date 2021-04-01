using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Models;

namespace WindowsFormsApp3.Data
{
    public class PetrolContext : DbContext
    {
        public PetrolContext()
            : base("PetrolDb")
        {

        }

        public DbSet<PetrolStation> PetrolPayments { get; set; }
    }
}
