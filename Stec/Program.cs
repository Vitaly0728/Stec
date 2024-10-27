namespace Stec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("2","f","c");
            Console.WriteLine($"Size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            Console.WriteLine($"Size = {s.Size}, Top = '{s.Top}'");
            s.Add("a");
            Console.WriteLine($"Size = {s.Size} , Top = '{s.Top}'");

            s.Merge(new Stack("1","2","3"));
            Console.WriteLine(s.Top);
            var a = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            Console.WriteLine(a.Top);            
        }
    }
}


    


