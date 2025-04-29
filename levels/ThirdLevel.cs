namespace levels.Third
{
    public class HashTable
    {
        private Trapezoid[] table;

        public HashTable(int size)
        {
            table = new Trapezoid[size];
        }

        private int Hash(double key)
        {
            return (int)key % table.Length;
        }

        public bool Insert(Trapezoid t)
        {
            int index = Hash(t.Area());
            for (int i = 0; i < table.Length; i++)
            {
                int probe = (index + i) % table.Length;
                if (table[probe] == null)
                {
                    table[probe] = t;
                    return true;
                }
            }
            return false;
        }

        public void RemoveByPerimeterRange(double min, double max)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] != null)
                {
                    double p = table[i].Perimeter();
                    if (p >= min && p <= max)
                    {
                        table[i] = null;
                    }
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"{i}: ");
                if (table[i] != null)
                    Console.WriteLine(table[i]);
                else
                    Console.WriteLine("-");
            }
        }
    }
}
