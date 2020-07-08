using System.Collections.Generic;

namespace Arrays
{
	class ContainsDuplicate
	{
        public bool ContainsDuplicateN(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            foreach (var i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    return true;
                }
                else
                {
                    dict[i] = i;
                }
            }

            return false;
        }
    }
}
