using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
	class TwoSum
    {
        public int[] GetTwoSumInNSquare(int[] nums, int target)
        {
            int[] indexOfAddingItems = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indexOfAddingItems[0] = i;
                        indexOfAddingItems[1] = j;
                        return indexOfAddingItems;
                    }
                }
            }

            return indexOfAddingItems;
        }

        public int[] TwoSumNLogN(int[] nums, int target)
        {
            int[] indexOfAddingItems = new int[2];

            var numsSorted = (int[])nums.Clone();
            Array.Sort(numsSorted);

            int lower = 0;
            int upper = nums.Length - 1;

            while (lower < upper)
            {
                if (numsSorted[lower] + numsSorted[upper] == target)
                {
                    break;
                }
                else if (numsSorted[lower] + numsSorted[upper] > target)
                {
                    upper--;
                }
                else
                {
                    lower++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == numsSorted[lower])
                {
                    indexOfAddingItems[0] = i;
                    break;
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == numsSorted[upper])
                {
                    indexOfAddingItems[1] = i;
                    break;
                }
            }

            return indexOfAddingItems;
        }
        public int[] TwoSumN(int[] nums, int target)
        {
            int[] indexOfAddingItems = new int[2];

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    indexOfAddingItems[0] = dict[nums[i]];
                    indexOfAddingItems[1] = i;
                    break;
                }
                else
                {
                    if (!dict.ContainsKey(target - nums[i]))
                    {
                        dict[target - nums[i]] = i;
                    }
                }
            }

            return indexOfAddingItems;
        }
    }
}
