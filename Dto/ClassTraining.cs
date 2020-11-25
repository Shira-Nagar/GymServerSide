using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class ClassTraining
    {
        public int Training_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int? quota { get; set; }
    }
}
