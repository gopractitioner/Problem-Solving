public class Solution {
    public string RemoveKdigits(string num, int k) {
        int n = num.Length;
        int currentDigit;
        Stack<int> stack = new Stack<int>();
        stack.Push(num[0] - '0');
        for (int i = 1; i < n; i++) 
        {
            currentDigit = num[i] - '0';
            // while (stack.Count() != 0 && stack.Peek() == 0) {
            //     stack.Pop();
            // }
            while (stack.Count() != 0 && stack.Peek() > currentDigit && k > 0)
            {
                stack.Pop();
                k--;
            }
            stack.Push(currentDigit);
        }
        // while (stack.Count() != 0 && stack.Peek() == 0) {
        //     stack.Pop();
        // }
        while (stack.Count() != 0 && k > 0) 
        {
            stack.Pop(); 
            k--;
        }   
        // StringBuilder ans = new StringBuilder();
        // while (stack.Count() > 0) ans.Append(stack.Pop());
        // while (ans.Length > 0 && ans[ans.Length-1] == '0') 
        // {
        //     ans.Remove(ans.Length-1, 1);
        // }
        // return ans.ToString()==""?"0":ans.ToString();
        StringBuilder reversedAnswer = new StringBuilder();
        StringBuilder answer = new StringBuilder();
        while (stack.Count() != 0) reversedAnswer.Append(stack.Pop());
        while (reversedAnswer.Length > 0 && reversedAnswer[reversedAnswer.Length-1] == '0') 
        {
            reversedAnswer.Remove(reversedAnswer.Length-1, 1);
        }
        int length = reversedAnswer.Length;
        for (int i = 0; i < length; i++) 
        {
            answer.Append(reversedAnswer[length - i - 1]);
        } 
        return answer.ToString()==""?"0":answer.ToString();
    }
}