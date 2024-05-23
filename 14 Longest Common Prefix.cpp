class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        string toReturn = "";

        for (int j = 0; j < strs[0].size(); j++){
            char prev = strs[0][j];
            if (prev == NULL){
                return toReturn;
            }
            int yes = 1;
            for (int i = 0; i < strs.size(); i++){
                if (strs[i][j] == prev){
                }
                else{
                    yes = 0;
                }
            }
            if (yes == 1){
                toReturn += prev;
            }
            else{
                return toReturn;
            }
        }
        return toReturn;
    }
};