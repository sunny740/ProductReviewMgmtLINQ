using NUnit.Framework;
using ProductReviews;
using System.Collections.Generic;

namespace Product_Review_Management
{
    public class Tests
    {
        ProductReview product;
        List<ProductReview> ProductReviewsList;

        [SetUp]
        public void Setup()
        {
            product = new ProductReview();
            ProductReviewsList = new List<ProductReview>();
        }

        [Test]
        public void ReturnCountofListCreated()
        {
            int expected = 25;
            int actual = product.AddProductReview();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void RetrieveTopThreeRecord()
        {
            int expected = 3;
            var actual = product.RetrieveTopThreeRecords();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckRetrieveAllRecords()
        {
            string expected = "7 3 3 15 7 ";
            string actual = product.RetrieveAllRecords();
            Assert.AreEqual(expected, actual);
        }

    }
}