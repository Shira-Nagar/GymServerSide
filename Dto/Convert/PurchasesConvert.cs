using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto.Convert
{
    public class PurchasesConvert
    {
        public static List<ClassPurchases> GetDtoAllPurchases(List<Dal.Purchases> p)
        {
            List<ClassPurchases> DtoPurchase = new List<ClassPurchases>();
            foreach(var item in p)
            {
                ClassPurchases cp = new ClassPurchases()
                {
                    customer_id = item.customer_id,
                    sub_id = item.sub_id,
                    status = item.status
                };
                DtoPurchase.Add(cp);
            }
            return DtoPurchase;
        }

        public static ClassPurchases GetSinglePurchase(Dal.Purchases p)
        {
            ClassPurchases cp = new ClassPurchases()
            {
                customer_id = p.customer_id,
                sub_id = p.sub_id,
                status = p.status
            };
            return cp;
        }

        public static Dal.Purchases PostPurchases(ClassPurchases p)
        {
            Dal.Purchases p1 = new Dal.Purchases()
            {
                customer_id = p.customer_id,
                sub_id = p.sub_id,
                status = p.status
            };
            return p1;
        }

        
    }
}
