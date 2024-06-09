class Solution(object):
    def lengthOfLastWord(self, s):
        """
        :type s: str
        :rtype: int
        """
        fullString = s.split()
        return len(fullString[len(fullString) - 1])