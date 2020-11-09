using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Convert
{
    public class PresenceConvert
    {
        public static List<ClassPresence> GetDtoPre(List<Presence> allp)
        {
            List<ClassPresence> DtoPre = new List<ClassPresence>();
            foreach (var item in allp)
            {
                ClassPresence p = new ClassPresence()
                {                   
                    lesson_id = item.lesson_id,
                    sub_id = item.sub_id,
                };
                DtoPre.Add(p);
            }
            return DtoPre;
        }
        public static Presence PostPreOne(ClassPresence Pre)
        {
            Presence p = new Presence()
            {
               
                lesson_id = Pre.lesson_id,
                sub_id = Pre.sub_id,
            };
            return p;
        }
    }
}
