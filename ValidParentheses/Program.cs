

var ts = DateTime.Now;
Console.WriteLine(Solution.IsValid("()[]{}"));
var tt = DateTime.Now - ts;
Console.WriteLine(tt.TotalMilliseconds);

//()[]{}
public static class Solution
{
    public static bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        var matchingBrackets = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        var stack = new Stack<char>();

        foreach (var ch in s)
        {
            if (matchingBrackets.ContainsKey(ch))
            {
                stack.Push(ch);
            }
            else if (matchingBrackets.ContainsValue(ch))
            {
                if (stack.Count == 0 || matchingBrackets[stack.Pop()] != ch)
                    return false;
            }
        }

        return stack.Count == 0;
    }

}