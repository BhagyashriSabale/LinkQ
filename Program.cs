namespace LinkQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview() {ProductId=1,UserId=1,Review="good",IsLike=true,Rating=80 },
                new ProductReview() {ProductId=2,UserId=2,Review="bad",IsLike=false,Rating=30 },
                new ProductReview() {ProductId=3,UserId=4,Review="average",IsLike=true,Rating=50 },
                new ProductReview() {ProductId=2,UserId=3,Review="good",IsLike=true,Rating=90 },
                new ProductReview() {ProductId=4,UserId=5,Review="bad",IsLike=false,Rating=20 },
                new ProductReview() {ProductId=1,UserId=6,Review="good",IsLike=true,Rating=80 }
            };
            Displayproducts(list);
            ProductReviewManagment.RetrieveTop3Records(list);
            Console.WriteLine();
        }
        public static void Displayproducts(List<ProductReview> list)
        {
            foreach(ProductReview item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}