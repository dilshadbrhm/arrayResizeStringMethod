using System.Text;

namespace ArrayResizeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine().Trim();
            Console.WriteLine(CustomSentence(sentence));
            StringBuilder sb = new StringBuilder();


        }
        public static void CustomResize(ref int[] nums, params int[] value)
        {
            int length = nums.Length + value.Length;
            int[] customNums = new int[length];
            for (int i = 0; i < nums.Length; i++)
            {
                customNums[i] = nums[i];
            }
            for (int i = 0; i < value.Length; i++)
            {
                customNums[nums.Length + i] = value[i];
            }
            nums = customNums;
        }
        public static string CustomSentence(string sentence)
        {
            StringBuilder result = new StringBuilder();
            
            char sym = ' ';
            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];
                if (c==' ')
                {
                    if (sym != ' ')
                    {
                        result.Append(' ');
                       sym = ' ';
                    }
                }
                else
                {
                    if (sym== ' ')
                    {
                        result.Append(char.ToUpper(c));
                       
                    }
                    else
                    {
                        result.Append(char.ToLower(c));
                    }
                   sym = c;
                }
            }
            return result.ToString().Trim();
        }
    }
}
