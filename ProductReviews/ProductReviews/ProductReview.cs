using System;
using System.Collections.Generic;
using System.Data;
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
        //UC2-TopThreeRecords
        public int RetrieveTopThreeRecords()
        {
            AddProductReview();
            var res = (from product in ProductList orderby product.Rating descending select product).Take(3).ToList();
            DisplayTheList();
            return res.Count;
        }
        //UC3-all records
        public string RetrieveAllRecords()
        {
            AddProductReview();
            string nameList = "";
            var productList = (from product in ProductList where product.Rating > 3 && (product.ProductID == 1 || product.ProductID == 4 || product.ProductID == 9) select product);
            foreach (var product in productList)
            {
                nameList += product.UserID + " ";
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.ProductID, product.UserID, product.Review, product.Rating, product.IsLike);
            }
            return nameList;
        }
        // UC 4: Retrieve count By ProductID
        public string CountByProductID()
        {
            string nameList = "";
            AddProductReview();
            var productList = ProductList.GroupBy(x => x.ProductID).Select(a => new { ProductID = a.Key, count = a.Count() });
            foreach (var element in productList)
            {
                Console.WriteLine("ProductId " + element.ProductID + " " + "Count " + " " + element.count);
                nameList += element.count + " ";
            }
            return nameList;
        }
        // UC 5: Retrieving Data By product id
        public string RetrieveDataByProductID()
        {
            string result = "";
            AddProductReview();
            var productList = ProductList.Select(product => new { ProductId = product.ProductID, Review = product.Review }).ToList();
            foreach (var element in productList)
            {
                Console.WriteLine("ProductId: " + element.ProductId + "\tReview: " + element.Review);
                result += element.ProductId + " ";
            }
            return result;
        }
        // UC 6 & 7: Skip Top Five records
        public string SkipTop5Record()
        {
            AddProductReview();
            string nameList = "";
            var result = (from product in ProductList orderby product.Rating descending select product).Skip(5).ToList();
            foreach (var element in result)
            {
                nameList += element.ProductID + " ";
            }
            return nameList;
        }
        // UC 8: Create Data Table
        public int CreateDataTable()
        {
            AddProductReview();
            productdt = new DataTable();
            productdt.Columns.Add("ProductId", typeof(Int32));
            productdt.Columns.Add("UserId", typeof(Int32));
            productdt.Columns.Add("Rating", typeof(Int32));
            productdt.Columns.Add("Review", typeof(string));
            productdt.Columns.Add("IsLike", typeof(bool));

            foreach (var data in ProductList)
            {
                productdt.Rows.Add(data.ProductID, data.UserID, data.Rating, data.Review, data.IsLike);
            }

            return productdt.Rows.Count;
        }
        /// TC 8: Adding a Productreview details in Data Table
        [Test]
        public void GivenCreateFunctionforDT_returnCountofListCreated()
        {
            int expected = 25;
            int actual = product.CreateDataTable();
            Assert.AreEqual(expected, actual);
        }
        //Display The Content
        public void DisplayTheList()
        {
            foreach (Product product in ProductList)
            {
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.ProductID, product.UserID, product.Review, product.Rating, product.IsLike);
            }
        }
    }
}