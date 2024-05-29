public class Solution {
    public string AddBinary(string a, string b) {
        int temp = 0;
        string result = "";
        while (Math.Min(a.Length, b.Length) < Math.Max(a.Length, b.Length)) {
            if (a.Length < b.Length) {
                a = "0" + a;
            }
            else {
                b = "0" + b;
            }
        } 

        for (int i = (a.Length - 1); i >= 0; i--) {
            if (a[i] == '0' && b[i] == '0') {
                if (temp == 0) {
                    result = "0" + result;
                }
                else {
                    result = "1" + result;
                    temp = 0;
                }
            }

            else if (a[i] == '1' && b[i] == '1') {
                if (temp == 0) {
                    result = "0" + result;
                    temp = 1;
                }
                else {
                    result = "1" + result;
                }
            }

            else  {
                if (temp == 0) {
                    result = "1" + result;
                }
                else {
                    result = "0" + result;
                }
            }
        }

        if (temp == 1) {
            result = "1" + result;
        }

        return result;
    }
} 