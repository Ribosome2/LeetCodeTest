namespace TestInConsoleApp
{
    public class Array_TwoSum
    {
        //给定一个已按照升序排列 的有序数组，找到两个数使得它们相加之和等于目标数。
        //函数应该返回这两个下标值 index1 和 index2，其中 index1 必须小于 index2。
        //说明:

        //返回的下标值（index1 和 index2）不是从零开始的。
        //你可以假设每个输入只对应唯一的答案，而且你不可以重复使用相同的元素。
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length > 1)
            {
                int index = 1;
                int curNum = numbers[0];
                while (index<numbers.Length)
                {
                   
                    if (numbers[index] != curNum)
                    {
                        int targetNum = target - curNum;
                        for (int i = index; i < numbers.Length; i++)
                        {
                            if (numbers[i] == targetNum)
                            {
                                return new[] {index , i + 1};
                            }
                        }

                        curNum = numbers[index];
                    }
                    else
                    {
                        if (curNum + numbers[index]==target)
                        {
                            return new[] { index, index+1 };
                        }
                    }
                    if (numbers[index] > target)
                    {
                        break;
                    }
                    index++;
                }
            }
           
            return new int[]{-1,-1};
        }

        public int[] TwoSum1(int[] numbers, int target)
        {
            //双指针法：
            int left = 0;
            int right = numbers.Length - 1;
            while (left<right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    return new[] {left + 1, right + 1};
                }else if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return new int[] { -1, -1 };
        }
    }
}