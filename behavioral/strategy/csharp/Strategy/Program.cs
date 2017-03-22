using System;

namespace Strategy
{
    interface ISortStrategy
    {
        int[] Sort(int[] dataset);
    }

    class BubbleSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] dataset)
        {
            Console.WriteLine("Sorting using buble sort");
            return dataset;
        }
    }

    class QuickSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] dataset)
        {
            Console.WriteLine("Sorting using quick sort");
            return dataset;
        }
    }

    class Sorter
    {
        protected ISortStrategy sorter;
        public Sorter(ISortStrategy sorter)
        {
            this.sorter = sorter;
        }
        public int[] Sort(int[] dataset)
        {
            return this.sorter.Sort(dataset);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] dataset = {1, 5, 4, 3, 2, 8};

            Sorter sorter;
            sorter = new Sorter(new BubbleSortStrategy());
            sorter.Sort(dataset);

            sorter = new Sorter(new QuickSortStrategy());
            sorter.Sort(dataset);

        }
    }
}
