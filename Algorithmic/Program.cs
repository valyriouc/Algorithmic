﻿namespace Algorithmic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubble = new BubbleSort(new List<int>() { 23, 2, 102, 10, 5, 230, 13, 54, 38, 6, 19, 23 });

            bubble.Sort();
        }
    }
}