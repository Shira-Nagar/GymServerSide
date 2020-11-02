using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Dto
{
    public class ClassSubscription
    {
        public string name { get; set; }
        public int lessons_num  { get; set; }
        public int sub_id { get; set; }
        public int? duration { get; set; }
        public int? training_id { get; set; }

        
    }
}
