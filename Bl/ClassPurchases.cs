using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bl
{
    public class ClassPurchases
    {
        public static List<Dto.ClassPurchases> GetAllPurchases()
        {
            return Dto.Convert.PurchasesConvert.GetDtoAllPurchases(Dal.ClassPurchases.GetAllPurchases());
        }

        public static Dto.ClassPurchases GetSinglePurchase(int id)
        {
            return Dto.Convert.PurchasesConvert.GetSinglePurchase(Dal.ClassPurchases.GetPurchasesById(id));
        }

        public static void PostPurchases(Dto.ClassPurchases p)
        {
            Dal.ClassPurchases.PostPurchase(Dto.Convert.PurchasesConvert.PostPurchases(p));
        }

        public static void DeletePurchase(int id)
        {
            Dal.ClassPurchases.DeletePurchase(id);
        }
    }
}
