using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFİRS_MOVİES
{
    public class Actor
    {
        //Otomatik olarak veritabanı tablosunda primary key olarak yansıtılacak
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //Null değer alabilen tip
        public Nullable<int> LanguagId { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<Film> Films { get; set; }


    }
}
