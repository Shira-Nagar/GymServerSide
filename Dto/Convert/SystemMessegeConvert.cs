using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

 namespace Dto.Convert
{
   public class SystemMessegeConvert
    { 
        public static List<ClassSystemMessege> GetAllSMessege(List<Dal.SystemMessege> Allm)
        {
            List<ClassSystemMessege> DtoSMessege = new List<ClassSystemMessege>();

            foreach (var item in Allm )
            {
                ClassSystemMessege m = new ClassSystemMessege()
                { 
                Messege_id = item.Messege_id,
                Messege_Content = item.Messege_Content,
                Creation_date = item.Creation_date,
                Deletion_date = item.deletion_date,
                };
                DtoSMessege.Add(m);
            } 
            return DtoSMessege;
        }

       
        public static ClassSystemMessege GetDtoSMessege(Dal.SystemMessege m)
        {
            ClassSystemMessege me= new ClassSystemMessege()
            {
                Messege_id = m.Messege_id,
                Messege_Content = m.Messege_Content,
                Creation_date = m.Creation_date,
                Deletion_date = m.deletion_date,
            };

            return me;
        }
        public static Dal.SystemMessege PostSMessege(ClassSystemMessege m)
        {
            Dal.SystemMessege me = new Dal.SystemMessege()
            {
                Messege_id = m.Messege_id,
                Messege_Content = m.Messege_Content,
                Creation_date = m.Creation_date,
                deletion_date = m.Deletion_date,
            };

            return me;
        }


    }
}
    