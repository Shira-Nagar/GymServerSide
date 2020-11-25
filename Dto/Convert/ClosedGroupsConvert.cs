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
                        name = item.name,
                        day = item.day,
                        trainer_id = item.trainer_id,                       
                        gender = item.gender,
                        actual_capacity = item.actual_capacity,
                        status = item.status,
                        time = item.time
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
                    day = Cg.day,
                    trainer_id = Cg.trainer_id,
                    gender = Cg.gender,
                    actual_capacity = Cg.actual_capacity,
                    status = Cg.status,
                    time = Cg.time
                };

                return c;
            }
            public static Dal.ClosedGroupes PostCgOne(ClassClosedGroups Cg)
            {
                Dal.ClosedGroupes c = new Dal.ClosedGroupes()
                {
                    name = Cg.name,
                    day = Cg.day,
                    trainer_id = Cg.trainer_id,
                    gender = Cg.gender,
                    actual_capacity = Cg.actual_capacity,
                    status = Cg.status,
                    time = Cg.time
                };
        

                return c;
            }
        }
    }


