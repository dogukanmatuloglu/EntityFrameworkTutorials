using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFIRST_MOVİES
{
    class Program
    {
        static void Main(string[] args)
        {

            Actor actor = new Actor() { LanguageID=1,Name="Kemal",Surname="Sunal"};
            MoviesEntities entities = new MoviesEntities();
            entities.Actor.Add(actor);
            entities.SaveChanges();


        }
    }
}
