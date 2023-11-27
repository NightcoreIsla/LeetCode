public class Solution {
    public int Reverse(int x) {
var str = x.ToString();
bool isNegative = str.StartsWith("-");
if (isNegative)
    str = str.Substring(1);
var num = Convert.ToInt64(new string(str.Reverse().ToArray()));
return num > Int32.MaxValue ? 0 : (Int32)num * (isNegative ? -1 : 1);
    }
}