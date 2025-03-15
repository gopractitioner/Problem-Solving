public class Solution
{
    public int Trap(int[] height)
    {
        int n = height.Length, sum = 0, topElement;
        int[] leftHeight = new int[n];
        int[] rightHeight = new int[n];
        Stack<int> LStack = new Stack<int>();
        Stack<int> RStack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            if (LStack.Count() != 0)
            {
                while (LStack.Count != 0 && LStack.Peek() <= height[i])
                {
                    LStack.Pop();
                }
                if (LStack.Count != 0)
                {
                    leftHeight[i] = LStack.Peek();
                }
                else
                {
                    LStack.Push(height[i]);
                }
            }
            else
            {
                LStack.Push(height[i]);
            }
        }

        for (int i = n - 1; i >= 0; i--)
        {
            if (RStack.Count() != 0)
            {
                while (RStack.Count != 0 && RStack.Peek() <= height[i])
                {
                    RStack.Pop();
                }
                if (RStack.Count != 0)
                {
                    rightHeight[i] = RStack.Peek();
                }
                else
                {
                    RStack.Push(height[i]);
                }
            }
            else
            {
                RStack.Push(height[i]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (height[i] < leftHeight[i] && height[i] < rightHeight[i])
            {
                sum = sum + Math.Min(leftHeight[i], rightHeight[i]) - height[i];
            }
        }
        return sum;
    }
}