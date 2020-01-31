using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class VideoStitching_Test
    {
//        你将会获得一系列视频片段，这些片段来自于一项持续时长为 T秒的体育赛事。这些片段可能有所重叠，也可能长度不一。
//
//        视频片段 clips[i]都用区间进行表示：开始于 clips[i][0] 并于 clips[i][1] 结束。我们甚至可以对这些片段自由地再剪辑，例如片段[0, 7] 可以剪切成[0, 1] + [1, 3] + [3, 7] 三部分。
//
//        我们需要将这些片段进行再剪辑，并将剪辑后的内容拼接成覆盖整个运动过程的片段（[0, T]）。返回所需片段的最小数目，如果无法完成该任务，则返回 -1 
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/video-stitching
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int VideoStitching(int[][] clips, int T)
        {
            int count = 0;

            //思路：从左到右找，找到包含需要片段的最小值的作为候选片段
            //在候选片段中选取后边值最大的
            int left = 0;
            int right = 0;
            while (right<T)
            {
                int tempIndex = -1;
                int tempRight = right;
                int len = clips.GetLength(0);
                for(int i = 0; i < len; i++)
                {
                    var clip = clips[i];
                    //左右为-1标记为已经选取
                    if (clip[0] != -1 && clip[1] != -1)
                    {
                        if (clip[0] <= left && clip[1] > right)
                        {
                            if (clip[1] > tempRight)
                            {
                                tempRight = clip[1];
                                tempIndex = i;
                            }
                        }
                    }
                }

                if (tempIndex !=-1)
                {
//                    Console.WriteLine("Select " + tempIndex);
                    var selectClip = clips[tempIndex];
                    count++;
                    if (selectClip[1] >= T)
                    {
                        return count;
                    }
                    left = selectClip[1];
                    right = left;
                   
                    //标记为已选取
                    selectClip[0] = -1;
                    selectClip[1] = -1;
                }
                else
                {
                    return -1;
                }
            }
            return count;
        }
    }
}
