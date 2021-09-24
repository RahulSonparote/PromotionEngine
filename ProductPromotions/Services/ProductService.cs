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
            int totalPriceOfA = (aCount / 3) * 130 + (aCount % 3 * aPrice);
            int totalPriceOfB = (bCount / 2) * 45 + (bCount % 2 * bPrice);
            int totalPriceOfC = (cCount * cPrice);
            int totalPriceOfD = (dCount * dPrice);
            return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD;
        }
    }
}
