namespace SN_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String str = "Hello World";

            // Get input from user
            char character;
        askChar:
            Console.Write("Enter the character: ");
            bool isValid = Char.TryParse(Console.ReadLine(), out character);
            if (!isValid)
            {
                goto askChar;
            }

            // Get the num of occurence
            int count = ShowNumOfOccurrence(str, character);

            Console.WriteLine($"Amount of {character} appear in {str}: {count} times");
        }

        private static int ShowNumOfOccurrence(string str, char character)
        {
            UInt16 count = 0;
            for (int index = 0; index < str.Length; index++)
            {
                if (character == str[index])
                {
                    count++;
                }
            }

            return count;
        }
    }
}