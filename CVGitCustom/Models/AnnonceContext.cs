using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGitCustom.Models
{
    class AnnonceContext : DbContext
    {
        public DbSet<File> Files {get; set;}

        public DbSet<Annonce> Annonces { get; set; }
    }
}
