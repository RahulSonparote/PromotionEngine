using ProductPromotions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPromotions.Services
{
    public interface IPromotionService
    {
        Promotion GetPromotionByProduct(string Product);
        List<Promotion> GetPromotions();
    }
}
