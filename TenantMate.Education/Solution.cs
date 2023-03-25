namespace TenantMate.Education;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var difference = new Dictionary<int,int>();

        for(var i=0; i<nums.Length; i++)
        {
            if(difference.ContainsKey(target-nums[i]))
                return new int[2]{difference[target-nums[i]],i};
            if(!difference.ContainsKey(nums[i]))
                difference.Add(nums[i],i);
        }

        return new int[2];
    }
}