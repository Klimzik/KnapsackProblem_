namespace KnapsackProblem
{
    internal class Result
    {
        public int TotalWeight { get; set; } = 0;
        public int TotalValue { get; set; } = 0;
        public List<Item> ResultItems { get; set; } = new List<Item>();

        public Result() { }

        public void Display() 
        {
            Console.WriteLine("Wartość przedmiotów w plecaku: "+ TotalValue);
            Console.WriteLine("Waga przedmiotów w plecaku: "+ TotalWeight);

            foreach (var item in ResultItems)
            {
                Console.WriteLine("Wartość: " + item.Value + ". Waga: " + item.Weight);
            }
        }
        public override string ToString()
        {
            string resultString = "Wartość przedmiotów w plecaku: " + TotalValue + Environment.NewLine;
            resultString += "Waga przedmiotów w plecaku: " + TotalWeight + Environment.NewLine;

            foreach (var item in ResultItems)
            {
                resultString += "Wartość: " + item.Value + ". Waga: " + item.Weight + Environment.NewLine;
            }

            return resultString;
        }

    }
}