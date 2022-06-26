using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviews
{
    public class ProductReview
    {
        public List<Product> ProductList = new List<Product>();

        // UC 1: Adding a Productreview details
        public int AddProductReview()
        {
            ProductList.Add(new Product() { ProductID = 2, UserID = 1, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductID = 2, UserID = 2, Review = "Good", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductID = 3, UserID = 10, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductID = 2, UserID = 5, Review = "Good", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductID = 1, UserID = 1, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductID = 2, UserID = 6, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductID = 4, UserID = 7, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductID = 5, UserID = 8, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductID = 3, UserID = 9, Review = "Average", Rating = 3, IsLike = false });
            ProductList.Add(new Product() { ProductID = 5, UserID = 4, Review = "Average", Rating = 3, IsLike = true });
            ProductList.Add(new Product() { ProductID = 7, UserID = 9, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductID = 9, UserID = 10, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductID = 4, UserID = 3, Review = "Good", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductID = 3, UserID = 2, Review = "Nice", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductID = 8, UserID = 9, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductID = 2, UserID = 3, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductID = 9, UserID = 3, Review = "Nice", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductID = 1, UserID = 15, Review = "Nice", Rating = 4, IsLike = true });
            ProductList.Add(new Product() { ProductID = 1, UserID = 10, Review = "Average", Rating = 2, IsLike = false });
            ProductList.Add(new Product() { ProductID = 1, UserID = 1, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductID = 2, UserID = 10, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductID = 4, UserID = 7, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductID = 5, UserID = 8, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductID = 3, UserID = 9, Review = "Nice", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductID = 5, UserID = 10, Review = "Average", Rating = 3, IsLike = true });

            return ProductList.Count;
        }
        public void DisplayTheList()
        {
            foreach (Product product in ProductList)
            {
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.ProductID, product.UserID, product.Review, product.Rating, product.IsLike);
            }
        }
    }
}