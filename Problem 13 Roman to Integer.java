class Solution {
	// takes string of roman numerals
	// returns int val represented by roman numerals
	
    public int romanToInt(String s) {
        int result = 0, prev = 0;

        for (int i = 0; i < s.length(); i++) {
            int curr = numeralToInt(s.charAt(i));
            if (prev < curr) {
                result += (curr - (2 * prev));
            } else {
                result += curr;
            }
            prev = curr;	// saves 1 ms
        }

        return result;
    }

	// takes symbol returns equivalent decimal val
    private int numeralToInt(char c) {
        switch(c) {
            case 'I':
            return 1;
            case 'V':
            return 5;
            case 'X':
            return 10;
            case 'L':
            return 50;
            case 'C':
            return 100;
            case 'D':
            return 500;
            case 'M':
            return 1000;
            default:
            return 0;
        }
    }
}