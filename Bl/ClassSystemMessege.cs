using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
     public class ClassSystemMessege
    { 
        public static List<Dto.ClassSystemMessege> GetAllMesseges()
        {
            return Dto.Convert.SystemMessegeConvert.GetAllSMessege(Dal.ClassSystemMessege.GetAllMesseges());
        }
        public static ClassSystemMessege GetOneMessege(int id)
        {
            return Dto.Convert.SystemMessegeConvert.GetDtoSMessege(Dal.ClassSystemMessege.GetMessege(id));
        }
        public static void PostSMesseges(Dto.ClassSystemMessege ms)
        {
            Dal.ClassSystemMessege.PostSMessege(Dto.Convert.SystemMessegeConvert.PostSMessege(ms));
        }
        public static void DeleteSMessege(int id)
        {
            Dal.ClassSystemMessege.DeleteSMessege(id);
        }
    }
}
