namespace Stec
{
    public class Stack
    {
        public StackItem? _top;    

        public int Size => CountItems();
        
        public Stack (params string[]? stackItems)
        {          
            foreach (var item in stackItems)
            {
                Add(item);
            }
        }
        
        public void Add(string item)
        {
            var stekItem = new StackItem(item);
            if (_top != null)
            {
                stekItem.previousItem = _top;
            }
            _top =stekItem;
        }
        public void Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Стек пуст.");
            }
            _top = _top.previousItem;                     
        }
        public static Stack Concat(params List<Stack> stacks)
        {
            var newStack = new Stack();

            foreach (var stack in stacks)
            {                
                var currentItem = stack._top;
                
                var itemsToAdd = new List<string>();
                
                while (currentItem != null)
                {
                    itemsToAdd.Add(currentItem.str);
                    currentItem = currentItem.previousItem;
                }

                for (int i = 0; i <= itemsToAdd.Count-1; i++)
                {
                    newStack.Add(itemsToAdd[i]);
                }
            }
            return newStack;
        }
       
        public  int CountItems()
        {
            int count = 0;
            var currentItem = _top;

            while (currentItem != null)
            {
                count++;
                currentItem = currentItem.previousItem;
            }

            return count;
        }


        
        public class StackItem
        {
            public string str;
            public StackItem? previousItem;
            public StackItem(string _str)
            {
                str= _str;
                previousItem = null;
            }

        }
    }
}


    


