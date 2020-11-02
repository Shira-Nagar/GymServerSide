using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
 namespace Bl
{
    public class ClassClosedGroups
    {
        public static List<Dto.ClassClosedGroups> GetAllClosedGroupes()
        {
            return Dto.Convert.ClosedGroupsConvert.GetDtoSub(Dal.ClassClosedGroups.GetAllClosedGroups());
        }
        public static Dto.ClassClosedGroups GetClosedGroups(int id)
        {
            return Dto.Convert.ClosedGroupsConvert.GetDtoClOne(Dal.ClassClosedGroups.GetClosedGroups(id));
        }
        public static void PostClosedGroups(Dto.ClassClosedGroups c)
        {
            Dal.ClassClosedGroups.PostClosedGroups(Dto.Convert.ClosedGroupsConvert.PostCgOne(c));
        }
        public static void DeleteClosedGroups(int id)
        {
            Dal.ClassClosedGroups.DeleteClosedGroups(id);
        }
    }
}
