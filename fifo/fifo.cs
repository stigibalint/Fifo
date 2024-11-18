using System;

namespace fifo
{
    public class FIFO
    {
        private double[] items;
        private int count;
        private int capacity;

        public FIFO() { }
        public FIFO(int initialCapacity = 100)
        {
            this.capacity = initialCapacity;
            this.items = new double[capacity];
            this.count = 0;
        }


        public void Add(double elem)
        {
            if (count == capacity)
            {
                Console.WriteLine("A tároló megtelt!");
                return;
            }

            items[count] = elem;
            count++;
        }
        public double Remove()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("A tároló üres!");
            }
            double removedItem = items[0];

            for (int i = 1; i < count; i++)
            {
                items[i - 1] = items[i];
            }
            count--;

            return removedItem;
        }

        public double[] Reverse()
        {
            double[] reversedItems = new double[count];
            for (int i = 0; i < count; i++)
            {
                reversedItems[i] = items[count - 1 - i];
            }
            return reversedItems;
        }
        public int Length()
        {
            return count;
        }

        public int GetSize()
        {
            return capacity;
        }
    }
}
