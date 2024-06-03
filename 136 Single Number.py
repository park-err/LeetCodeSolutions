class Solution(object):
    def singleNumber(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """

        # works better and faster than last submission
        # issue with space complexity
        
        if len(nums) == 1:
            return nums[0]

        nums = sorted(nums)

        for i in range(0, len(nums) - 1):
            if (nums[i] == nums[i+1]) or (nums[i-1] == nums[i]):
                continue
            else:
                return nums[i]
        

        return nums[len(nums) - 1]