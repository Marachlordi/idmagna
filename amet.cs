public class CurTask
{
    public int solution(string s)
    {
        int maxLen = 0;
        int curLen = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                curLen++;
                maxLen = Math.Max(maxLen, curLen);
            }
            else
            {
                curLen = 0;
            }
        }
        return maxLen;
    }
}
