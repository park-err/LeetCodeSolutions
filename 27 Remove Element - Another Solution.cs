public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0) {
            return 0;
        }
        int counter = 0;
        int size = nums.Length;

        for (int i = 0; i < size; i++) {
            if (nums[i] == val) {
                for (int j = (size-1); j >= 0; j--) {
                    if (nums[j] != val && j > i) {
                        nums[i] = nums[j];
                        nums[j] = val;
                        counter++;
                        break;
                    }
                }
            }
            else { counter++; }
        }

        return counter;
    }
}