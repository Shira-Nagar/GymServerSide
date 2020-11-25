using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bl
{
    public class ClassSubsciptionsTypes
    {
        public static List<Dto.ClassSubscriptionsTypes> GetAllSubscriptions()
        {
            return Dto.Convert.SubscriptionsTypesConvert.GetDtoSub(Dal.ClassSubscriptionsTypes.GetAllSubscription());
        }
        public static Dto.ClassSubscriptionsTypes GetSubscription(int id)
        {
            return Dto.Convert.SubscriptionsTypesConvert.GetDtoSubOne(Dal.ClassSubscriptionsTypes.GetSubscription(id));
        }
        public static void PostSubscription(Dto.ClassSubscriptionsTypes c)
        {
            Dal.ClassSubscriptionsTypes.PostSubscription(Dto.Convert.SubscriptionsTypesConvert.PostSubOne(c));
        }
        public static void DeleteSubscription(int id)
        {
            Dal.ClassSubscriptionsTypes.DeleteSubscription(id);
        }

    }
}
