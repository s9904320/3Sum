using System;
using System.Collections.Generic;

namespace _3Sum
{
    public class ThreeSum
    {
        public static IList<IList<int>> ThreeSumAns(int[] nums)
        {
            var answer = new List<IList<int>>();
            List<IList<int>> anslist = new List<IList<int>>(); //{ new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 } };

            if (nums == null || nums.Length == 0)
            {
                return answer;
            }
            else
            {
                Array.Sort(nums);
                for(int firstNum = 0; firstNum +2 < nums.Length; firstNum++)
                {
                    if(firstNum > 0 &&nums[firstNum]== nums[firstNum - 1])
                    {
                        break;
                    }
                    int secNum = firstNum + 1;
                    int thrNum = nums.Length - 1;
                    int target = -nums[firstNum];
                    
                    while(secNum < thrNum)
                    {
                        if(nums[secNum] + nums[thrNum] == target)
                        {
                            IList<int> list = new int[] { nums[firstNum], nums[secNum], nums[thrNum] };
                            anslist.Add(list);
                            secNum++;
                            thrNum--;

                            while(secNum<thrNum && nums[secNum]== nums[secNum - 1])
                            {
                                secNum++;
                            }
                            while (secNum < thrNum && nums[thrNum] == nums[thrNum + 1])
                            {
                                thrNum--;
                            }
                        }
                        else if(nums[secNum] + nums[thrNum] > target)
                        {
                            thrNum--;
                        }
                        else
                        {
                            secNum++;
                        }
                    }
                }
                return anslist;
            }
            
        }
    }
}
