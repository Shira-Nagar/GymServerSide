using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bl
{
    public class ClassSubsciption
    {
        public static List<Dto.ClassSubscription> GetAllSubscriptions()
        {
            return Dto.Convert.SubscriptionsConvert.GetDtoSub(Dal.ClassSubscription.GetAllSubscription());
        }
        public static Dto.ClassSubscription GetSubscription(int id)
        {
            return Dto.Convert.SubscriptionsConvert.GetDtoSubOne(Dal.ClassSubscription.GetSubscription(id));
        }
        public static void PostSubscription(Dto.ClassSubscription c)
        {
            Dal.ClassSubscription.PostSubscription(Dto.Convert.SubscriptionsConvert.PostSubOne(c));
        }
        public static void DeleteSubscription(int id)
        {
            Dal.ClassSubscription.DeleteSubscription(id);
        }

    }
}
