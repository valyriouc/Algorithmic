namespace Algorithmic
{
    internal class BubbleSort : Sort
    {
        public BubbleSort(List<int> bubbles) : base(bubbles) { }

        public override void Sorting()
        {
            while (!base.IsSorted)
            {
                IsSorted = true;
                for (int i = 0; i < Bubbles.Count - 1; i++)
                {
                    if (Bubbles[i] > Bubbles[i + 1])
                    {
                        int tmp = Bubbles[i + 1];
                        Bubbles[i + 1] = Bubbles[i];
                        Bubbles[i] = tmp;

                        IsSorted = false;

                        Print();
                        Thread.Sleep(500);
                    }
                }
            }
        }
    }
}
