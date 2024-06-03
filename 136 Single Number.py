class Solution(object):
    def singleNumber(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """

        # uses bitwise xor to find the result
        # 0 ^ num = num
        # num ^ num = 0
        # when this runs, the result left over will = num not duplicated in list
        # how it works
        # https://www.youtube.com/watch?v=xQPxiajgZLY

        result = 0

        for i in nums:
            result ^= i
        
        return result