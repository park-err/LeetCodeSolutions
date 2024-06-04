class Solution {
    public int reverse(int x) {
        long result = 0;
        if (x > Integer.MAX_VALUE || x < Integer.MIN_VALUE) {
            return 0;
        }
        while (x != 0) {
            result = (result * 10) + (x % 10);
            x /= 10;
			
			// checks if reverse number exceeds int limit
            if (result > Integer.MAX_VALUE || result < Integer.MIN_VALUE) {
                return 0;
            }
        }
        return (int)result;
    }
}