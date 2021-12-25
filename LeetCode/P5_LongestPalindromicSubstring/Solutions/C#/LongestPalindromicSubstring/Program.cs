public class Solution {
    
 public  String LongestPalindrome(String s) {
	 
     
    var max = 0;
    var len = s.Length;

    if (len == 1) return s;
     
    
    if (s == new String(s.Reverse().ToArray())) return s;

    var start = 0;
    var end = 0;

    for (int i = 0; i < len; i++)
    {
        //subString = $"{s[i]}";
        var slen = 1;
        for (int j = i + 1; j < len; j++)
        {
            // subString = s[i..(j + 1)];
            slen++;

            int k = 0;

            var isPalinDrome = true;

            while (k < slen / 2)
            {
                if (s[i + k] != s[(slen - (k + 1)) + i])
                {
                    isPalinDrome = false;
                    break;
                }

                k++;
            }

            if (isPalinDrome)
            {
                if (slen > max)
                {
                    max = slen;
                    // result = subString;
                    // result = s[i..(j + 1)];
                    start = i;
                    end = (j + 1);
                }

            }
        }

        slen = 0;

    }
    return s[start..end] == "" ? $"{s[0]}" : s[start..end];
 
 }
}