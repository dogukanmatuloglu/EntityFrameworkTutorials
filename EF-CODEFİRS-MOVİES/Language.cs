using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFİRS_MOVİES
{
    public class Language
    {
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Director> Directors { get; set; }



    }
}
