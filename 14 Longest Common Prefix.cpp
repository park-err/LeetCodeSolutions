class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        string commonPrefix = strs[0], temp = "";
        int minLength;
        for (int i = 1; i < strs.size(); i++) {
            minLength = min(strs[i].length(), commonPrefix.length());
            if (minLength == 0) {
                return "";
            }
            for (int j = 0; j < minLength; j++) {
                if (strs[i].at(j) == commonPrefix.at(j)) {
                    temp += strs[i].at(j);
                    if (j == (minLength - 1)) {
                        commonPrefix = temp;
                        temp = "";
                    }
                }
                else {
                    commonPrefix = temp;
                    temp = "";
                    break;
                }
            }
        }

        return commonPrefix;
    }
};