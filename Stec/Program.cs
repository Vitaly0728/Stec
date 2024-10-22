using System.Linq;

namespace Stec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("2","f","c");
            Console.WriteLine($"Size = {s.Size}, Top = '{s._top?.str}'");
            s.Pop();
            Console.WriteLine($"Size = {s.Size}, Top = '{s._top?.str}'");
            s.Add("a");
            Console.WriteLine();
            Console.WriteLine($"Size = {s.Size} , Top = '{s._top?.str}'");

            s.Merge(new Stack("a", "f", "fdsaf"));
            Console.WriteLine(s._top.str);
            var a = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            Console.WriteLine(a._top.str);
        }
    }
}


    


