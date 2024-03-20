using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests"), InternalsVisibleTo("WinFormsApp")]
namespace KnapsackProblem
{
    internal class Problem
    {
        public int n { get; set; }                                  // ilosc elementów do wygenerownia do wlozenia do plecaka
        public int Seed { get; set; } 
        public List<Item> Items { get; set; } = new List<Item>();   // lista wygenrowanych przedmiotow
        public int Capacity { get; set; }                           // pojemnosc plecaka (weight)

        public Problem(int n = 10, int capacity = 20, int seed = 10) 
        {
            Random random = new Random(seed);
            Capacity = capacity;  
            for (int i = 0; i < n; i++)
            {
                Items.Add(new Item(random));
            }
        }

        public Result Solve ()
        {
            Result result = new Result();
            int copyCapacity = Capacity;

            Items = Items.OrderByDescending(item => item.Ratio).ToList();

            foreach (var item in Items)
            {
                if(copyCapacity - item.Weight >= 0)
                {
                    result.ResultItems.Add(item);
                    result.TotalValue += item.Value;
                    result.TotalWeight += item.Weight;
                    copyCapacity -= item.Weight;
                }
            }
            if (result.ResultItems.Count == 0)
            {
                return new Result();
            }
            result.Display();
            return result;
        }
    }
}
