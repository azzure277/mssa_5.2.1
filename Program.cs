namespace mssa_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("Hello World")); // Output: 5
            Console.WriteLine(LengthOfLastWord(" fly me to the moon ")); // Output: 4
        }

        static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            int length = 0;
            int i = s.Length - 1;

            // Skip trailing spaces
            while (i >= 0 && s[i] == ' ')
                i--;

            // Count the length of the last word
            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }

            return length;
        }
    }
}
