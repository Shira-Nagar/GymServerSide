using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto.Convert
{
    public class SubscriptionsTypesConvert
    {
        public static  List<ClassSubscriptionsTypes> GetDtoSub(List<Dal.SubscriptionsTypes> allS)
        {
            List<ClassSubscriptionsTypes> DtoSu = new List<ClassSubscriptionsTypes>();
            foreach (var item in allS)
            {
                ClassSubscriptionsTypes s = new ClassSubscriptionsTypes()
                {
                    name = item.name,
                    duration = item.duration,
                    lessons_num = item.lessons_num,
                    price = item.price

                };
                DtoSu.Add(s);
            }
            return DtoSu;
        }
        public static ClassSubscriptionsTypes GetDtoSubOne(Dal.SubscriptionsTypes sub)
        {
                ClassSubscriptionsTypes s = new ClassSubscriptionsTypes()
                {
                    name = sub.name,
                    duration = sub.duration,
                    lessons_num = sub.lessons_num,
                    price = sub.price
                };
              
            return s;
        }
        public static Dal.SubscriptionsTypes PostSubOne(ClassSubscriptionsTypes sub)
        {
            Dal.SubscriptionsTypes s = new Dal.SubscriptionsTypes()
            {
                name = sub.name,
                duration = sub.duration,
                lessons_num = sub.lessons_num,
                price = sub.price
            };

            return s;
        }
    }
}
