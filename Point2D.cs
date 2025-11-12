//Task1----------------------------------------------------------
/*int[] numbers = {1, 3, 5, 2, 4, 9, 0, 6 };
int max = numbers.Max();
int min = numbers.Min();
Console.WriteLine($"Max: {max}, Min: {min}");*/
//Task2----------------------------------------------------------
/*int[] num = { 3, 5, 7, 1, 2, 12, 8 };
Array.Sort(num);

for (int i = 0; i < num.Length / 2; i++)
{
    int temp = num[i];
    num[i] = num[num.Length - 1 - i];
    num[num.Length - 1 - i] = temp;
}

foreach (int n in num)
{
    Console.WriteLine(n);
}
*/
//Task3----------------------------------------------------------
/*List<int> num = new List<int> { 1, 2, 2, 3, 4, 5, 6, 7, 8, 9 };
List<int> cut = num.Where(eded => eded % 2 == 0).ToList();
Console.WriteLine("cut ededler:");
foreach (int eded in cut)
{
    Console.WriteLine(eded);
}
*/
//Task4----------------------------------------------------------
/*enum Weekday
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}
class Program
{
    static void Main()
    {
        Weekday today = Weekday.Sunday;
        if (IsWorkday(today))
            Console.WriteLine($"{today} — workday.");
        else
            Console.WriteLine($"{today} — rest.");
    }
    static bool IsWorkday(Weekday day) => day != Weekday.Saturday && day != Weekday.Sunday;
}
*/
//Task5----------------------------------------------------------
/*struct Point
{
    public int X, Y;
    public double Length => Math.Sqrt(X * X + Y * Y);
}
class Program
{
    static void Main()
    {
        Point p = new Point { X = 3, Y = 4 };
        Console.WriteLine($"{p.X}, {p.Y} : {p.Length}");
    }
}*/
//Task6----------------------------------------------------------
/*public interface IGreeter
{
    string Greet(string name) => $"Hello, {name}";
}
class Greeter : IGreeter
{
}
class Program
{
    static void Main()
    {
        IGreeter greeter = new Greeter();
        Console.WriteLine(greeter.Greet("Nihad"));
    }
}*/
//Task7----------------------------------------------------------
/*string[] arr = { "A", null, "B" };
bool Null = arr.Any(s => s == null);
Console.WriteLine(Null);*/
//Task8----------------------------------------------------------
/*List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 9 };
List<int> unique = ints
            .Where((x, index) => ints.IndexOf(x) == index)
            .ToList();

unique.ForEach(Console.WriteLine);*/
//Task9----------------------------------------------------------
/*List<int> Index(int[] nums, int value)
    {
    List<int> ints = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        ints.Add(i);
    }
    return ints;
    }
int[] num = {1, 2, 3, 4 };
var ind = Index(num, 1);
Console.WriteLine(string.Join(" ", ind));*/
//Task10---------------------------------------------------------
/*string setir = "salam nihad";
for (int i = 0; i < setir.Length; i++)
{
    if (setir[i] == ' ')
    {
        i++;
        setir = setir.Substring(0, i) + char.ToUpper(setir[i]) + setir.Substring(i + 1).ToLower();
        
    }
}
Console.WriteLine(setir);
*/
//Task11---------------------------------------------------------
//Task12---------------------------------------------------------

internal class Point2D
{
    private int v1;
    private int v2;

    public Point2D(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    internal object Move(int v)
    {
        throw new NotImplementedException();
    }

    internal object Move(int v1, int v2)
    {
        throw new NotImplementedException();
    }
}