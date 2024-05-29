class Solution {
public:
    vector<vector<int>> generate(int numRows) {
        vector<vector<int>> pTri(numRows, vector<int>(1));
        pTri[0][0] = 1;
        if (numRows == 1) {
            return pTri;
        }
        for (int i = 1; i < numRows; i++) {
            vector<int> temp(i + 1);
            temp[0] = 1; temp[i] = 1;
            for (int j = 1; j < i; j++) {
                temp[j] = pTri[i - 1][j - 1] + pTri[i - 1][j];
            }
            pTri[i] = temp;
        }
        return pTri;
    }
};