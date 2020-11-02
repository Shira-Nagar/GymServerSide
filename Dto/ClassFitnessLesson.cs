using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class ClassFitnessLesson
    {
        public string name { get; set; }
        public int trainer_id { get; set; }
        public int lesson_id { get; set; }
        public string  day { get; set; }
        public TimeSpan time { get; set; }
        public int? quota_training { get; set; }
        
    }
}
