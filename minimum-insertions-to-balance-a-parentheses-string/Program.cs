namespace minimum_insertions_to_balance_a_parentheses_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    // https://leetcode.com/problems/minimum-insertions-to-balance-a-parentheses-string/solutions/780199/java-c-python-straight-forward-one-pass/
    public class Solution
    {
        public int MinInsertions(string s)
        {
            // case 1 ( - close needed 2   , for each open we need 2 close
            // case 1 () - close missing 1
            // case 1 )) - open missing 1
            int close_needed = 0;
            int open_missing = 0;
            int close_missing = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    // example - "()("
                    if (close_needed % 2 != 0)
                    {
                        close_missing++;
                        close_needed--;
                    }
                    close_needed += 2;
                }
                else
                {
                    close_needed--;
                    // example = (()))))
                    if (close_needed < 0)
                    {
                        open_missing++;
                        close_needed += 2;
                    }
                }
            }

            return close_needed + open_missing + close_missing;
        }
    }
}
