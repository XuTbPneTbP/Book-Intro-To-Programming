using System.Collections.Generic;

namespace Demos
{
    public static class IListExtension
    {
        public static void IncreaseWith(this IList<int> myDemoList, int amount)
        {
            for (int i = 0; i < myDemoList.Count; i++)
            {
                myDemoList[i] += amount;
            }
        }
    }
}
