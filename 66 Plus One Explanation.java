class Solution {
    public int[] plusOne(int[] digits) {
		for (int i = digits.length - 1; i >= 0; i--) {
			if (digits[i] < 9) {
				digits[i]++;
				return digits;
				// starting from the last element
				// if the last element is not nine, increment and return array
				// if the array is [1,9,9], then this is what increments 1 to 2
			}
			else {
				digits[i] = 0;
			}
			// if the element is nine, change to zero and move to the previous element
			// if the array is [9,9], it will break on the first 9 with [0,0]
		}

		// once it breaks, we can create a new array with a new length
		// the length will be + 1 the length of the original
		// in this instance, the added number will always be 1
		// the rest of the elements will be 0
		// create an empty array with length + 1 and make first element 1
		// this would result in 1,0,0...

		digits = new int[digits.length + 1];
		digits[0] = 1;
		return digits;
	}
}