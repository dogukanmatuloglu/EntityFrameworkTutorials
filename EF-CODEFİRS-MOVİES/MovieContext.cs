using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFİRS_MOVİES
{
    public class MovieContext:DbContext
    {
        public MovieContext() : base()
        { }
            public virtual DbSet<Actor> Actors{ get; set; }
            public virtual DbSet<Language> Languages { get; set; }
            public virtual DbSet<Director> Directors { get; set; }
            public virtual DbSet<Film> Films { get; set; }


        
    }
}
