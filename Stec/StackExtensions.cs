namespace Stec
{
    public static class StackExtensions
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            var tempStack = new Stack();
            
            while (s2.Size > 0)
            {
                tempStack.Add(s2.Pop());
                s1.Add(tempStack.Pop());
            }            
        }
    }
}


    


