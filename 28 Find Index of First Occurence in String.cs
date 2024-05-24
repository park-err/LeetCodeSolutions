class Solution {
public:
    int strStr(string haystack, string needle) {
        int size = needle.length();
        char firstLetterNeedle = needle.at(0);
        char lastLetterNeedle = needle.at(size - 1);

        for (int i = 0; i < haystack.length(); i++) {
            if (haystack.substr(i, size) == needle) {
                return i;
            }
        }

        return -1;
    }
};