using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto.Convert
{
    public class SubscriptionsConvert
    {
        public static  List<ClassSubscription> GetDtoSub(List<Dal.Subscriptions> allS)
        {
            List<ClassSubscription> DtoSu = new List<ClassSubscription>();
            foreach (var item in allS)
            {
                ClassSubscription s = new ClassSubscription()
                {
                name = item.name,
                duration = item.duration,
                lessons_num=item.lessons_num,
                training_id = item.training_id,
                sub_id=item.sub_id,
                
                };
                DtoSu.Add(s);
            }
            return DtoSu;
        }
        public static ClassSubscription GetDtoSubOne(Dal.Subscriptions sub)
        {
                ClassSubscription s = new ClassSubscription()
                {
                    name = sub.name, 
                    duration=sub.duration,
                    lessons_num = sub.lessons_num,
                    training_id = sub.training_id,
                    sub_id = sub.sub_id,
                };
              
            return s;
        }
        public static Dal.Subscriptions PostSubOne(ClassSubscription sub)
        {
            Dal.Subscriptions s = new Dal.Subscriptions()
            {
                name = sub.name,
                 duration=sub.duration,
                lessons_num = sub.lessons_num,
                training_id = sub.training_id,
                sub_id = sub.sub_id,
            };

            return s;
        }
    }
}
