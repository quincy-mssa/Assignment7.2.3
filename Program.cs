namespace Assignment7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "swallow";
            string s2 = "wallows";

            Console.WriteLine(AnagramComp(s1, s2) ? "Is an anagram" : "Is NOT an anagram");
        }
        //method to check if two strings are anagrams
        static bool AnagramComp(string s1, string s2)
        {
            //edge case, if lengths differ, they cannot be anagrams
            if (s1.Length != s2.Length)
                return false;

            //sort both strings
            char[] s1Array = s1.ToCharArray();
            char[] s2Array = s2.ToCharArray();
            Array.Sort(s1Array);
            Array.Sort(s2Array);

            //compare sorted strings
            return new string(s1Array) == new string(s2Array);
        }

    }
}
