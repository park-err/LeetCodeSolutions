class Solution(object):
    def singleNumber(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        # this works but is incredibly slow
        # times out if list is too long

        if len(nums) == 1:
            return nums[0]

        single = False

        for i in range(0, len(nums)):
            for j in range(0, len(nums)):
                if (nums[i] == nums[j]) ^ (i == j):
                    single = False
                    break
                else:
                    single = True
            if single:
                return nums[i]
        

        return -1