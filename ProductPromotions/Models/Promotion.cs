using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPromotions.Models
{
    public class Promotion
    {
        public string ProductId { get; set; }
        public int TotalCount { get; set; }
        public int DiscountPrice { get; set; }
    }
}
