class Solution(object):
    def isHappy(self, n):
        """
        :type n: int
        :rtype: bool
        """
        # stores prior results. if the same one is seen twice end recursion
        # original math problem states to loop infinitely, but we can prove
        # that if a number eventually loops to itself then it will never reach 1
        prev = [0]
        happyNum = 0
        while happyNum is not 1:
            happyNum = self.findSumSqrsDigits(n)
            
            if happyNum in prev:
                return False
            else:
                prev.append(happyNum)
                
            n = happyNum
        
        return True
    
    # improvements that could be made:
        # change range. currently in compliance with constraints
    def findSumSqrsDigits(self, n):
        # iterates through digits of n
        # returns sum of squares
        sumSqrs = 0
        
        for i in range(1, 11):
            # isolate digit
            temp = int((n % (10 ** i)) / (10 ** (i-1)))
            sumSqrs += temp ** 2
            if (n % (10 ** i) == n):
                break
        
        return sumSqrs
    
