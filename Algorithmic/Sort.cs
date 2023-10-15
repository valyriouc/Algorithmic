using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic
{
    internal abstract class Sort
    {
        public List<int> Bubbles { get; set; }

        protected bool IsSorted { get; set; }

        public Sort(List<int> bubbles)
        {
            Bubbles = bubbles;
            IsSorted = false;
        }

        public abstract void Sorting();

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

            Thread.Sleep(500);
        }
    }
}
