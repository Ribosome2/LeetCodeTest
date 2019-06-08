namespace TestInConsoleApp
{
    //假设按照升序排序的数组在预先未知的某个点上进行了旋转。
//    搜索一个给定的目标值，如果数组中存在这个目标值，则返回它的索引，否则返回 -1 。
//    你可以假设数组中不存在重复的元素。
//    你的算法时间复杂度必须是 O(log n) 级别。

   
    public class SearchRotatedArray_Test
    {
        int[] nums;
        int target;
        public int Find_rotate_index(int left, int right)
        {
            if (nums[left] < nums[right])
                return 0;

            while (left <= right)
            {
                int pivot = (left + right) / 2;
                if (nums[pivot] > nums[pivot + 1])
                    return pivot + 1;
                else
                {
                    if (nums[pivot] < nums[left])
                        right = pivot - 1;
                    else
                        left = pivot + 1;
                }
            }
            return 0;
        }

        public int search(int left, int right)
        {
            /*
            Binary Search
            */
            while (left <= right)
            {
                int pivot = (left + right) / 2;
                if (nums[pivot] == target)
                    return pivot;
                else
                {
                    if (target < nums[pivot])
                        right = pivot - 1;
                    else
                        left = pivot + 1;
                }
            }
            return -1;
        }

        public int Search(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;

            int n = nums.Length;

            if (n == 0)
                return -1;
            if (n == 1)
                return this.nums[0] == target ? 0 : -1;

            int rotate_index = Find_rotate_index(0, n - 1);

            // if target is the smallest element
            if (nums[rotate_index] == target)
                return rotate_index;
            // if array is not rotated, Search in the entire array
            if (rotate_index == 0)
                return search(0, n - 1);
            if (target < nums[0])
                // Search in the right side
                return search(rotate_index, n - 1);
            // Search in the left side
            return search(0, rotate_index);
        }

    }
}