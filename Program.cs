namespace Week_3_Challenge_Lab_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check if it is a palindrome: ");
            string myString = Console.ReadLine();

            if(IsPalindrome(myString))
            {
                Console.WriteLine($"{myString} = is a palindrome");
            }
            else
            {
                Console.WriteLine($"{myString} = is not a palindrome");
            }


        }

        public static bool IsPalindrome(string myString)
        {
            
            for (int i = 0; i < myString.Length / 2; i++)
            {
                if (myString[i] != myString[myString.Length - i - 1])
                    return false;
            }
            return true;
        }
        
    }
}
