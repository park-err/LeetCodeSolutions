class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {
        int n = nums.size();
        int curr = n / 2;
        
        if (target <= nums[0]) {
            return 0;
        }
        else if (target == nums[n - 1]) {
            return n - 1;
        }
        else if (target > nums[n - 1]) {
            return n;
        }
        else {
            while ((nums[0] <= nums[curr]) && (nums[curr] <= nums[n - 2])) {
                if (nums[curr] > target) {
                    if (nums[curr - 1] < target) {
                        return curr;
                    }
                    curr--;
                }
                else if (nums[curr] < target) {
                    curr++;
                    if (nums[curr] > target) {
                        return curr;
                    }
                }
                else { break; }
            }
        }
        return curr;
    }
};