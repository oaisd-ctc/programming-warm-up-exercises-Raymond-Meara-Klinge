using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int a = 37;
            int b = 6;
            int c = -23;
            string words;
            string word2;
            string word3;
            int[] nums = { 43, 9, 52, 75, 12, 80, 234, 65 };
            char he = 'o';

            Random rnd = new Random();
            number = rnd.Next(1, 15);

            words = "How could you count me out like that?";
            word2 = "Hello, how has your day been?";
            word3 = "racecar";

            Console.WriteLine($"{a} + {b} = {Add(a, b)}");
            Console.WriteLine($"The number {number} is even: {IsEven(number)}");
            Console.WriteLine($"The highest number between {a}, {b}, and {c} is {MaxOfThree(a, b, c)}");
            Console.WriteLine($"The string message, {words}, is {StringLength(words)} words long.");
            Console.WriteLine($"The string message, {word2}, starts with the word ''Hello'': {StartsHello(word2)}");
            Console.WriteLine($"The reversed string message of {word2} is: {ReverseString(word2)}");
            Console.WriteLine($"{number}! = {Factorial(number)}");
            Console.WriteLine($"{number} is a prime number : {IsPrime(number)}");
            Console.WriteLine($"The Fibonacci number in the {number}th position is {Fibonacci(number)}");
            Console.WriteLine($"The largest number in the given integer array is {LargestInArray(nums)}");
            Console.WriteLine($"The word {word3} is a palindrome: {IsPalindrome(word3)}");
            Console.WriteLine($"The sum of the given integer array is {ArraySum(nums)}");
            Console.WriteLine($"The letter '{he}' appears in the phrase ''{words}'' {CharCount(words, he)} times.");
            Console.WriteLine(ConcatenateStrings(words, word2));
            Console.WriteLine($"Swapping the ending characters of the first phrase would give you: {SwapEnds(words)}");

        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            if (a > b)
            {
                return Math.Max(a, c);
            }
            return Math.Max(b, c);
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            int total = 0;
            string[] word = s.Split(' ');
            foreach (string wor in word)
            {
                total++;
            }
            return total;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            return s.StartsWith("Hello");

            // Additional answer to handles any casing situation:
            return s.ToLower().StartsWith("hello");
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            char[] charArrayz = new char[charArray.Length];
            int inv = 0;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                charArrayz[inv] = charArray[i];
                inv++;
            }
            return new string(charArrayz);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n <= 1) return 1;
            int total = 1;
            int[] facts = new int[n];
            foreach (int fact in facts)
            {
                facts[fact] = n;
                n--;
                total *= facts[fact];
            }
            return total;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            int num1 = 0;
            int num2 = 1;
            int total = 0;
            for (int i = 2; i < n + 1; i++)
            {
                total = num1 + num2;
                num1 = num2;
                num2 = total;
            }
            return total;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (largest < numbers[i])
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            char[] word = s.ToCharArray();
            for (int i = 0; i <= word.Length - 1; i++)
            {
                for (int l = word.Length - 1; l >= 0; l--)
                {
                    if (word[i] != word[l])
                    {
                        return false;
                    }
                    i++;
                }
            }
            return true;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            char[] letter = s.ToCharArray();
            for (int i = 0; i <= letter.Length - 1; i++)
            {
                if (letter[i] == c)
                {
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            return str1 + ' ' + str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char[] lets = s.ToCharArray();
            char[] l = new char[lets.Length];
            char firstChar = lets[0];
            char lastChar = s[lets.Length - 1];
            l[0] = lastChar;
            for (int i = 1; i <= l.Length - 1; i++)
            {
                l[i] = lets[i];
            }
            l[l.Length - 1] = firstChar;
            string st = new(l);
            return st;
        }
    }
}
