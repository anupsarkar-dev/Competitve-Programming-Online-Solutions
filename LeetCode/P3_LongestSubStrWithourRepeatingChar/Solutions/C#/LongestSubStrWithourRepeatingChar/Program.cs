var s1 = "pwwkew";
var s2 = "dvdf";
var s3 = "abcabcbb";
var s4 = "anviaj";
var s5 = " ";
var s6 = "  ";
var s7 = "aa";

Console.WriteLine($" {s1} -> Expected 3 = Result {LengthOfLongestSubstring2(s1)}");
Console.WriteLine($" {s2} -> Expected 3 = Result {LengthOfLongestSubstring2(s2)}");
Console.WriteLine($" {s3} -> Expected 3 = Result {LengthOfLongestSubstring2(s3)}");

Console.WriteLine($" {s4} -> Expected 5 = Result {LengthOfLongestSubstring2(s4)}");
Console.WriteLine($" {s5} -> Expected 1 = Result {LengthOfLongestSubstring2(s5)}");
Console.WriteLine($" {s6} -> Expected 1 = Result {LengthOfLongestSubstring2(s6)}");
Console.WriteLine($" {s7} -> Expected 1 = Result {LengthOfLongestSubstring2(s7)}");

 
int LengthOfLongestSubstring2(string s)
{
    if (s.Length < 2)
        return s.Length;

    var hash = new HashSet<char>();
    var result = 0;
    char next ;
    var count = 1;


    for (int i = 0; i < s.Length; i++)
    {
        hash.Add(s[i]);

        for (int j = i + 1; j < s.Length; j++)
        {
            next =s[j];

            if (!hash.Contains(next))
            {
                count++;
                hash.Add(next);
                result = count >= result ? count : result;
            }
            else
            {
                result = count >= result ? count : result;
                hash.Clear();
                break;
            }

        }
        count = 1;
    }
    return result;
}
