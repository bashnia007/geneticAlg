using System;
using System.Collections.Generic;

namespace GeneticAlgorithm
{
    class Algorithm
    {
        private Dictionary<Arcticle, float> profits = new Dictionary<Arcticle, float>(); 
        private const int Population = 100;
        private float GetProbability(Arcticle arcticle)
        {
            float result = ((Generator.MaxPrice + 1) - arcticle.Price)/Generator.MaxPrice*arcticle.Relevance;
            return (result >= 1 ) ? 1 : result;
        }

        private float GetProfit(Arcticle arcticle)
        {
            return arcticle.Profit*GetProbability(arcticle);
        }

        public List<Arcticle> GetAdvice()
        {
            List<Arcticle> generation = GetFirstGeneration();
            while (true)
            {
                generation = GetNextGeneration(generation);
                if (IsBestGeneration(generation)) break;
            }
            const int number = 4;
            
            return GetTop(number, generation);
        }
        // todo реализовать выбор number лучших из словаря
        private List<Arcticle> GetTop(int number, List<Arcticle> generation)
        {
            var result = new List<Arcticle>();
            foreach (var profit in profits)
            {
                
            }
            return result;
        }

        private bool IsBestGeneration(List<Arcticle> generation)
        {
            
        }

        private List<Arcticle> GetNextGeneration(List<Arcticle> generation)
        {
            List<Arcticle> bests = GetTop(30, generation);

            CreateCrossing(CreateMutation(bests));

        }

        private List<Arcticle> CreateMutation(List<Arcticle> bests)
        {
            throw new NotImplementedException();
        }

        private void CreateCrossing(List<Arcticle> bests)
        {
            throw new NotImplementedException();
        }

        private readonly ShopDbEntities _dataBase = new ShopDbEntities();
        private List<Arcticle> GetFirstGeneration()
        {
            List<Arcticle> firstGen = new List<Arcticle>();
            Random random = new Random();

            
            for (var i = 0; i < Population; i++)
            {
                int id = random.Next(Generator.ArticlesCount);
                firstGen.Add();
            }

            return firstGen;
        }
    }
}
