using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFİRS_MOVİES
{
    public class Film
    {
        [ForeignKey("Director")]
        public int FilmID { get; set; }
        
        public string Title { get; set; }
        
        public virtual Director Director { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
