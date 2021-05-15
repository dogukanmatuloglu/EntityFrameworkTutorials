using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFİRS_MOVİES
{
  
    public class Director
    {
    
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }
        public Nullable<int> DirectorLanguageID { get; set; }
       
        
      
        public virtual Language Language { get; set; }

        
        

    }
}
