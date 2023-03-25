using System.Diagnostics;
using TenantMate.Education;

int[] nums = {1, 2, 3, 8};
var target = 5;

var solution = new Solution();

var res = solution.TwoSum(nums, target);

foreach (var num in res)
{
    Console.WriteLine(num);
}

Console.ReadLine();

