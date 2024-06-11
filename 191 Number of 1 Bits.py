class Solution(object):
    def hammingWeight(self, n):
        """
        :type n: int
        :rtype: int
        """
        count = 0
        temp = bin(n).replace("0b", "") 
        for i in temp:
            if i == '1':
                count += 1
            
        
        return count