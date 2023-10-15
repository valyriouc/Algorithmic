namespace Algorithmic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectionSorting();
            //BubbleSorting();
        }

        static void SelectionSorting()
        {
            SelectionSort select
                = new SelectionSort(new List<int>() { 23, 2, 102, 10, 5, 230, 12, 19, 32, 78, 92, 13, 54, 38, 6, 19, 23 });

            select.Sorting();
        }

        static void BubbleSorting()
        {
            BubbleSort bubble
                = new BubbleSort(new List<int>() { 23, 2, 102, 10, 5, 230, 12, 19, 32, 78, 92, 13, 54, 38, 6, 19, 23 });

            bubble.Sorting();
        }
    }
}