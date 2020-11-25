using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public  class ClassSystemMessege
    {
        public int Messege_id { get; set; }
        public string Messege_Content { get; set; }
        public DateTime? Creation_date { get; set; }
        public DateTime? Deletion_date { get; set; }
    }
}
