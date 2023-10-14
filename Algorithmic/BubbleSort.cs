using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic
{
    internal class BubbleSort
    {
        public bool Sorted { get; set; } 

        public List<int> Bubbles { get; }

        public BubbleSort(List<int> bubbles)
        {
            Bubbles = bubbles;
            Sorted = false;
        }

        public void Sort()
        {
            while(!Sorted)
            {
                Sorted = true;
                for (int i = 0; i < Bubbles.Count - 1; i++)
                {
                    if (Bubbles[i] > Bubbles[i + 1])
                    {
                        int tmp = Bubbles[i + 1];
                        Bubbles[i+1] = Bubbles[i];
                        Bubbles[i] = tmp;

                        Sorted = false;

                        Print();
                        Thread.Sleep(500);
                    }
                }
            }
        }

        public void Print()
        {
            Console.Clear();

            foreach (int bubble in Bubbles)
            {
                string bubRepres = string.Empty;
                for (int i = 0; i < bubble; i++)
                {
                    if (i == 100)
                    {
                        break;
                    }

                    bubRepres += '#';
                }

                bubRepres += $" [{bubble}]";
                Console.WriteLine(bubRepres);
            }
        }
    }
}
