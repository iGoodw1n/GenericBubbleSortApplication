namespace GenericBubbleSortApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object[] arr = { 2, 1, -4, 3, 0 };
            //object[] arr = { "Bob", "Henry", "Andy", "Greg" };

            object[] arr = new Employee[]
            {
                new Employee { Id = 4, Name = "John" },
                new Employee { Id = 2, Name = "Bob" },
                new Employee { Id = 3, Name = "Greg" },
                new Employee { Id = 1, Name = "Tom" }
            };

            SortArray sortArray = new SortArray();

            sortArray.BubbleSort(arr);

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            return this.Id.CompareTo(((Employee)obj).Id);
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }

    public class SortArray
    {
        public void BubbleSort(object[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (((IComparable)arr[j]).CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(arr, j);
                    }
                }
            }
        }

        private void Swap(object[] arr, int j)
        {
            object temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}