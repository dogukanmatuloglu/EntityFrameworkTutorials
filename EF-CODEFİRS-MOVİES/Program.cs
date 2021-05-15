using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFİRS_MOVİES
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieContext context = new MovieContext();
            context.Database.Create();
        }
    }
}
