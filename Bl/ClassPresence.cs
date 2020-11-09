using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;


namespace Bl
{
   public  class ClassPresence
   {
        public static List<Dto.ClassPresence> GetAllPresences()
        {
            return Dto.Convert.PresenceConvert.GetDtoPre(Dal.ClassPresence.GetAllPresence());
        }
   
        public static void PostPresence(Dto.ClassPresence p)
        {
            Dal.ClassPresence.PostPresence(Dto.Convert.PresenceConvert.PostPreOne(p));
        }

   }
}