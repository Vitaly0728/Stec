namespace Stec
{
    public class Stack
    {
        public StackItem? Top => stroka.Count > 0 ? stroka[stroka.Count - 1] : null;

        public List<StackItem> stroka = new List<StackItem>();      

        public int Size => stroka.Count;
        
        public Stack (params string[] stackItems)
        {
            foreach (var items in stackItems)
            {
                var _items = new StackItem(items);
                if(Top!=null)
                {
                _items.previousItem= Top;
                }
                stroka.Add(_items);
                
            }
           
        }

        public void Add(string item)
        {
            var stekItem = new StackItem(item);
            stroka.Add(stekItem);
        }
        public void Pop()
        {
            if (stroka.Count == 0)
            {
                throw new InvalidOperationException("Стек пуст.");
            }            
            stroka.Remove(Top);
            
        }
        public static Stack Concat(params List<Stack> stacks)
        {
            var a = new Stack("");
            for (int i = 0; i < stacks.Count; i++)
            {
                for (int j = stacks[i].stroka.Count - 1; j >= 0; j--)
                {
                    a.stroka.Add(stacks[i].stroka[j]);
                }
            }

            return a;
        }
        public class StackItem
        {
            public string str;
            public StackItem previousItem;
            public StackItem(string _str)
            {
                str= _str;
            }

        }
    }
}


    


