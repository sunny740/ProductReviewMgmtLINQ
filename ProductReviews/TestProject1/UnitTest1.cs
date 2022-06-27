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
        /// TC 4: Retrive the Data count By productId
        [Test]
        public void TestMethodForCountByProductId()
        {
            string expected = "6 4 4 3 4 1 2 1 ";
            string actual = product.CountByProductID();
            Assert.AreEqual(expected, actual);
        }
        /// TC 5: Retrieving Data By product ID
        [Test]
        public void TestMethodForRetriveDataProductId()
        {
            string expected = "2 2 3 2 1 2 4 5 3 5 7 9 4 3 8 2 9 1 1 1 2 4 5 3 5 ";
            string actual = product.RetrieveDataByProductID();
            Assert.AreEqual(expected, actual);
        }
        /// TC 6 & 7: Skip top Five records
        [Test]
        public void Given_SkipTopFiveRecords()
        {
            string expected = "4 3 9 1 3 3 5 5 2 3 9 1 2 1 2 5 7 8 1 5 ";
            string actual = product.SkipTop5Record();
            Assert.AreEqual(expected, actual);
        }
        /// TC 8: Adding a Productreview details in Data Table
        [Test]
        public void Given_CreateDataTable()
        {
            int expected = 25;
            int actual = product.CreateDataTable();
            Assert.AreEqual(expected, actual);
        }
        /// TC 9: Retrieve the records whose column islike has true using DataTable
        [Test]
        public void TestMethodForReturnsOnlyIsLikee()
        {
            string expected = "1 10 1 6 7 8 4 9 10 9 3 15 1 10 7 8 10 ";
            string actual = product.RetrieveAllTheData();
            Assert.AreEqual(expected, actual);
        }
        /// TC 10: Average of rating ProductId
        [Test]
        public void TestMethodAverageofRating_ProductID()
        {
            string expected = "3.3 3.2 2 5 2 1 3 1 ";
            string actual = product.AverageRatingOfEachProductId();
            Assert.AreEqual(expected, actual);
        }
        /// TC 11: Returns All Records From The List
        [Test]
        public void TestMethodForReviewAllRecords()
        {
            string expected = "2 3 15 9 ";
            string actual = product.ReturnsAllRecordsFromTheList();
            Assert.AreEqual(expected, actual);
        }
    }
}