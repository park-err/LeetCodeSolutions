// retested some other algs and this is the fastest according to leetcode

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0) {
            return 0;
        }
        int counter = 0;
        int size = nums.Length;	// saves some time
        int[] temp = new int[size];
        
        for (int i = 0; i < size; i++) {
            if (nums[i] == val) {
                counter++;						// increase counter before
                temp[(size - counter)] = val;	// as to not be out of bounds
            }
            else {
                temp[i - counter] = nums[i];	// this method keeps rest of array in tact
            }									// [1,2,3,4,5] -> [1,2,4,5,3]
        }

        for (int i = 0; i < size; i++) {
            nums[i] = temp[i];					// nums = temp
        }
        return (size - counter);				// return size - amount of vals
    }
}