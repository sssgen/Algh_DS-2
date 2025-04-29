using levels.First;
using levels.Second;
using levels.Third;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- Перший рівень ---");
        var firstTable = new levels.First.HashTable(10);
        firstTable.Insert(new Trapezoid());
        firstTable.Insert(new Trapezoid());
        firstTable.Insert(new Trapezoid());
        firstTable.Print();

        Console.WriteLine("\n--- Другий рівень ---");
        var secondTable = new levels.Second.HashTable(10);
        secondTable.Insert(new Trapezoid());
        secondTable.Insert(new Trapezoid());
        secondTable.Insert(new Trapezoid());
        secondTable.Print();

        Console.WriteLine("\n--- Третій рівень ---");
        var thirdTable = new levels.Third.HashTable(10);
        thirdTable.Insert(new Trapezoid());
        thirdTable.Insert(new Trapezoid());
        thirdTable.Insert(new Trapezoid());
        Console.WriteLine("До видалення:");
        thirdTable.Print();
        thirdTable.RemoveByPerimeterRange(10, 25);
        Console.WriteLine("Після видалення (периметр у діапазоні 10-25):");
        thirdTable.Print();
    }
}
