namespace Stec
{
    public class Stack
    {
        private  StackItem? _top; 
        public string Top => _top?.Str;
        public int Size { get; private set; } = 0;

        public Stack (params string[]? stackItems)
        {          
            foreach (var item in stackItems)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Add(item);
                }
            }
        }

        public void Add(string item)
        {
            if (string.IsNullOrEmpty(item))
                throw new ArgumentNullException(nameof(item), "Элемент не может быть пустым или null");

            _top = new StackItem(item, _top);
            Size++;
        }
        public string Pop()
        {
            if (_top == null)
                throw new InvalidOperationException("Стек пустой");

            string topValue = _top.Str;
            _top = _top.PreviousItem;
            Size--;
            return topValue;
        }
        public static Stack Concat(params List<Stack> stacks)
        {
            var newStack = new Stack();

            foreach (var stack in stacks)
            {
                var tempStack = new Stack();

                while (stack.Size > 0)
                {
                    tempStack.Add(stack.Pop());
                    newStack.Add(tempStack.Pop());
                }
            }
            return newStack;
        }      
        
        public class StackItem
        {
            public string Str { get; set; }
            public StackItem PreviousItem { get; set; }            
            public StackItem(string _str, StackItem previous)
            {
                Str= _str;
                PreviousItem = previous;
            }

        }
    }
}


    


