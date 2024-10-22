namespace Stec
{
    public static class StackExtensions
    {
        public static void Merge(this Stack stack, Stack stack1)
        {
            var currentItem = stack1._top;
            
            var itemsToAdd = new List<string>();
           
            while (currentItem != null)
            {
                itemsToAdd.Add(currentItem.str); 
                currentItem = currentItem.previousItem;
            }

            for (int i = 0; i <= itemsToAdd.Count - 1; i++)
            {
                stack.Add(itemsToAdd[i]);
            }

        }     
    }
}


    


