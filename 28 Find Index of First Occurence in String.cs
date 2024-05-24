class Solution {
public:
	// first attempt was able to build my own find method
	// this is faster than the original using built in find
    int strStr(string haystack, string needle) {
        if(haystack.size()<needle.size())
        {
            return -1;
        }
		
		// if index of needle is not equal to non-position then return index
		// a non-position is a constant used by the compiler
		// the npos is thrown when needle is not found, thus breaking the if
		// and returning -1 or not found
		
        if((haystack).find(needle)!=string::npos)
        {
            return (haystack).find(needle);
        }
      return -1;  
    }
};