namespace KnapsackProblem
{
    internal class Item
    {
        public int Value { get; set; }
        public int Weight{ get; set; }
        public double Ratio { get; set; }

        public Item(Random random, int min = 1, int max = 10) 
        {
            Weight = random.Next(min, max);
            Value = random.Next(min, max);
            Ratio = (double)Value / Weight;

            //Console.WriteLine(Weight + "  " + Value + "  " + Ratio);
        }
    }
}