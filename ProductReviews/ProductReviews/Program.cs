using System;
namespace ProductReviews
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductReview productReview = new ProductReview();
            productReview.AddProductReview();
            productReview.DisplayTheList();
            productReview.RetrieveTopThreeRecords();
            productReview.RetrieveAllRecords();
            productReview.CountByProductID();
            productReview.RetrieveDataByProductID();
            productReview.SkipTop5Record();
            productReview.CreateDataTable();
            productReview.AverageRatingOfEachProductId();
        }
    }
}