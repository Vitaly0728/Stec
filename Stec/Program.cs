using System.Linq;

namespace Stec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("a","v");
            Console.WriteLine($"Size = {s.Size}, Top = '{s.Top.str}'");
            s.Pop();
            Console.WriteLine($"Size = {s.Size}, Top = '{s.Top.str}'");
            s.Add("a");
            foreach (var x in s.stroka) Console.Write(x.str + ":");
            Console.WriteLine();
            Console.WriteLine($"Size = {s.Size} , Top = ' {s.Top.str}'");

            s.Merge(new Stack("a", "f", "fdsaf"));
            foreach (var x in s.stroka) Console.Write(x.str + " ");

            Console.WriteLine();
            var a = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            foreach (var x in a.stroka) Console.Write(x.str + " ");

            
        }
    }
}


    


