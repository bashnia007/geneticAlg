namespace GeneticAlgorithm
{
    class Algorithm
    {
        private float GetProbability(Arcticle arcticle)
        {
            float result = ((Generator.MaxPrice + 1) - arcticle.Price)/Generator.MaxPrice*arcticle.Relevance;
            return (result >= 1 ) ? 1 : result;
        }

        private float GetProfit(Arcticle arcticle)
        {
            return arcticle.Profit*GetProbability(arcticle);
        }


    }
}
