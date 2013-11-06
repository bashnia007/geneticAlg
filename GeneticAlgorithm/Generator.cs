using System;

namespace GeneticAlgorithm
{
    public class Generator
    {
        public const int MaxPrice = 5000;
        public const int MaxRelevation = 10;
        public const int MaxProfit = 5000;
        public const int MaxCount = 100;
        public const int CategoryCount = 10;
        public const int ArticlesCount = 10;
        private readonly ShopDbEntities _dataBase = new ShopDbEntities();
        
        public void GenerateData()
        {
            for (var i = 0; i < ArticlesCount; i++)
            {
                var arcticle = new Arcticle();
                var price = new Random();
                var relevation = new Random();
                var profit = new Random();
                var count = new Random();
                var category = new Random();
                arcticle.Price = price.Next(MaxPrice);
                arcticle.Profit = profit.Next(MaxProfit);
                arcticle.Relevance = relevation.Next(MaxRelevation);
                arcticle.Category = category.Next(CategoryCount);
                arcticle.Count = count.Next(MaxCount);
                arcticle.Id = i+1;
                _dataBase.AddToArcticles(arcticle);
                _dataBase.SaveChanges();
            }
        }
    }
}
