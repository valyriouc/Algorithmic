using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic
{
    internal class SelectionSort : Sort
    {
        public SelectionSort(List<int> bubbles) : base(bubbles)
        {

        }

        public override void Sorting()
        {
            int length = Bubbles.Count - 1;
            while (true)
            {
                int highest = 0;
                int index = 0;

                for (int i = 0; i <= length; i++)
                {
                    if (Bubbles[i] > highest)
                    {
                        highest = Bubbles[i];
                        index = i;
                    }
                }

                int tmp = Bubbles[length];
                Bubbles[length] = highest;
                Bubbles[index] = tmp;

                length -= 1;

                Print();

                if (length == 0)
                {
                    break;
                }
            }
        }
    }
}
