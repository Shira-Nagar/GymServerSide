using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Convert
{
   public  class ClosedGroupsConvert
    {
       
            public static List<ClassClosedGroups> GetDtoSub(List<Dal.ClosedGroupes> allCg)
            {
                List<ClassClosedGroups> DtoCg = new List<ClassClosedGroups>();
                foreach (var item in allCg)
                {
                    ClassClosedGroups cg = new ClassClosedGroups()
                    {
                        training_id = item.trainig_id,
                        name = item.name,
                        descripition = item.descripition,
                        team_id = item.team_id,

                    };
                    DtoCg.Add(cg);
                }
                return DtoCg;
            }
            public static ClassClosedGroups GetDtoClOne(Dal.ClosedGroupes Cg)
            {
                ClassClosedGroups c = new ClassClosedGroups()
                {
                    name = Cg.name,
                    descripition = Cg.descripition,
                    training_id = Cg.trainig_id,
                    team_id = Cg.team_id,
                };

                return c;
            }
            public static Dal.ClosedGroupes PostCgOne(ClassClosedGroups Cg)
            {
                Dal.ClosedGroupes c = new Dal.ClosedGroupes()
                { 
                    team_id = Cg.team_id,
                    name = Cg.name,
                    descripition = Cg.descripition,
                   
                    trainig_id = Cg.training_id,
                };
        

                return c;
            }
        }
    }


