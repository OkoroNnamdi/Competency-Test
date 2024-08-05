using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Oriented_Database.Models
{
   public  class DatabaseSetting
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? CustomerCollectionName { get; set; }
        
    }
}
