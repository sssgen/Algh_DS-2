namespace levels.First
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
            if (table[index] == null)
            {
                table[index] = t;
                return true;
            }
            return false;
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
