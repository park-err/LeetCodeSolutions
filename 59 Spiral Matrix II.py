class Solution(object):
    def generateMatrix(self, n):
        """
        :type n: int
        :rtype: List[List[int]]
        """
        left, top = 0, 0
        right, bottom = n - 1, n - 1
        val = 1

        matrix = [[0] * n for i in range (n)]

        while left <= right:
            # fill in every val in outer top row

            for i in range(left, right + 1):
                matrix[top][i] = val
                val += 1
            # top row is filled move to next row
            top += 1
            
            # fill in every val in outer right column

            for i in range(top, bottom + 1):
                matrix[i][right] = val
                val += 1
            # right column is filled move left one
            right -= 1

            # fill in every val in outer bottom row (reverse)

            for i in range(right, left - 1, -1):
                matrix[bottom][i] = val
                val += 1
            bottom -= 1

            # fill in every val in outer left row (reverse)
            for i in range (bottom, top - 1, -1):
                matrix[i][left] = val
                val += 1
            left += 1


        return matrix