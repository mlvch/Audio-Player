using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BassPlayerApp
{
    class AppContext: DbContext
    {

        public DbSet<Song> Songs { get; set; }

        public AppContext() : base("DefaultConnection")
        {

        }

    }
}
