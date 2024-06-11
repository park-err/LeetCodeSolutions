class Solution(object):
    def permute(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        result = []

        # base case
        if (len(nums) == 1):
            return [nums[:]]

        for i in range(len(nums)):
            # divide into smaller arrays
            n = nums.pop(0)
            perms = self.permute(nums)

            # backtrack
            for perm in perms:
                perm.append(n)
            result.extend(perms)
            # add value that was popped back to array
            nums.append(n)
        return result
