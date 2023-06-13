using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQ
{
    internal class ProductReviewManagment
    {
        public static void RetrieveTop3Records(List<ProductReview> list)
        {
            Console.WriteLine("\n Retrieve Top3 Records");
            List <ProductReview> top3Records = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.Displayproducts(top3Records);
        }   
    }
}
