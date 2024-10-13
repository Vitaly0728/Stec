namespace Stec
{
    public static class StackExtensions
    {
        public static void Merge(this Stack stack, Stack stack1)
        {

            for (int i = stack1.stroka.Count - 1; i >= 0; i--)
            {
                stack.stroka.Add(stack1.stroka[i]);
            }
        }
    }
}


    


