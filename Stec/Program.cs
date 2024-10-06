using System.Linq;

namespace Stec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("a", "b", "c");
            Console.WriteLine($"Size = {s.item.Size}, Top = '{s.item.Top}'");
            s.Pop();
            Console.WriteLine($"Size = {s.item.Size}, Top = '{s.item.Top}'");
            s.Add("a");
            foreach (var x in s.item.stroka) Console.Write(x + ":");
            Console.WriteLine();
            Console.WriteLine($"Size = {s.item.Size}, Top = '{s.item.Top}'");

            s.Merge(new Stack("a", "f", "fdsaf"));
            foreach (var x in s.item.stroka) Console.Write(x + " ");

            var a = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            foreach (var x in a.item.stroka) Console.Write(x + " ");

        }
    }
    public static class StackExtensions
    {
        public static void Merge(this Stack stack, Stack stack1)
        {

            for (int i = stack1.item.stroka.Count - 1; i >= 0; i--)
            {
                stack.item.stroka.Add(stack1.item.stroka[i]);
            }
        }
    }
    public class Stack
    {
        StackItem item = new StackItem();
        public Stack(params string[] initialItems)
        {
            var s = new StackItem();
            foreach (var items in initialItems)
            {
                s.stroka.Add(items);
            }
        }

        public void Add(string LastItem)
        {
            item.stroka.Add(LastItem);
        }
        public string Pop()
        {
            if (item.stroka.Count == 0)
            {
                throw new InvalidOperationException("Стек пуст.");
            }


            string lastItem = item.stroka[item.stroka.Count - 1];
            item.stroka.RemoveAt(item.stroka.Count - 1);
            return lastItem;
        }
        public static Stack Concat(params List<Stack> stacks)
        {
            var a = new Stack();
            for (int i = 0; i < stacks.Count; i++)
            {
                for (int j = stacks[i].item.stroka.Count - 1; j >= 0; j--)
                {
                    a.item.stroka.Add(stacks[i].item.stroka[j]);
                }
            }
            return a;
        }
        public class StackItem
        {
            public List<string> stroka = new List<string>();
            public int Size => stroka.Count;
            public string Top => stroka.Count > 0 ? stroka[stroka.Count - 1] : null;
        }
    }
}


    


