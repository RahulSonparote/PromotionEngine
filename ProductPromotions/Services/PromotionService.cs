using ProductPromotions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPromotions.Services
{
    public class PromotionService : IPromotionService
    {
        public Promotion GetPromotionByProduct(string Product)
        {
            return GetPromotions().Where(x => x.ProductId == Product.ToUpper()).FirstOrDefault();
        }

        public List<Promotion> GetPromotions()
        {
            return new List<Promotion>
            {
                new Promotion { ProductId = "A",TotalCount = 3,DiscountPrice = 130},
                new Promotion { ProductId = "B",TotalCount = 2,DiscountPrice = 45},
            };
        }
    }
}
