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
        public static void RetrieveRecordsBasedonProductidandRating(List<ProductReview> list)
        {
            Console.WriteLine("\n Retrieve Records Based on Productid and Rating");
            List<ProductReview> result = list.Where(p=>p.Rating>3 && (p.ProductId==1 || p.ProductId==4 || p.ProductId==9)).ToList();
            Program.Displayproducts(result);
        }
    }
}
