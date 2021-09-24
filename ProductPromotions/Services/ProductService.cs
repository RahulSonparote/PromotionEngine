using ProductPromotions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPromotions.Services
{
    public class ProductService : IProductService
    {
        
        public int GetTotalPrice(List<Product> products)
        {
            var promotions = new PromotionService();
            int aCount = 0;
            int aPrice = 50;
            int bCount = 0;
            int bPrice = 30;
            int cCount = 0;
            int cPrice = 20;
            int dCount = 0;
            int dPrice = 15;

            foreach (Product pr in products)
            {
                switch (pr.Id)
                {
                    case "A":
                    case "a":
                        aCount += 1;
                        break;
                    case "B":
                    case "b":
                        bCount += 1;
                        break;
                    case "C":
                    case "c":
                        cCount += 1;
                        break;
                    case "D":
                    case "d":
                        dCount += 1;
                        break;
                }
            }
            var totalPriceOfA = aCount * aPrice;
            var promotionForA = promotions.GetPromotionByProduct("A");
            if (promotionForA != null)
            {
                totalPriceOfA = (aCount / promotionForA.TotalCount) * promotionForA.DiscountPrice + (aCount % promotionForA.TotalCount * aPrice);
            }
            int totalPriceOfB = (bCount * bPrice);
            var promotionForB = promotions.GetPromotionByProduct("B");
            if (promotionForB != null)
            {
                totalPriceOfB = (bCount / promotionForB.TotalCount) * promotionForB.DiscountPrice + (bCount % promotionForB.TotalCount * bPrice);
            }
            int totalPriceOfC = (cCount * cPrice);
            var promotionForC = promotions.GetPromotionByProduct("C");
            if (promotionForC != null)
            {
                totalPriceOfC = (cCount / promotionForC.TotalCount) * promotionForC.DiscountPrice + (cCount % promotionForC.TotalCount * cPrice);
            }
            int totalPriceOfD = (dCount * dPrice);
            var promotionofD = promotions.GetPromotionByProduct("D");
            if (promotionofD != null)
            {
                totalPriceOfD = (dCount / promotionofD.TotalCount) * promotionofD.DiscountPrice + (dCount % promotionofD.TotalCount * dPrice);
            }
            return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD;
        }
    }
}
