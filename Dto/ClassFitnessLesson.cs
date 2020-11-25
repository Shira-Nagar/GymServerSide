using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class ClassFitnessLesson
    {
        public int lesson_id { get; set; }
        public int name { get; set; }
        public string day { get; set; }
        public TimeSpan time { get; set; }
        public int trainer_id { get; set; }
        public string gender { get; set; }
        public int actual_capacity { get; set; }
        public string status { get; set; }
    }
}
