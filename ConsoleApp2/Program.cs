using System;
namespace ConsoleApp2
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string string_input = Console.ReadLine();
            int i, len, vowels, consonants;
            vowels = 0;
            consonants = 0;
            len = string_input.Length;


            Console.WriteLine("Reverse the given string: {0}", StringReverse(string_input));
            Console.WriteLine("Convert the given string to UPPERCASE: {0}", string_input.ToUpper());
            Console.WriteLine("Convert the given string to lowercase: {0}", string_input.ToLower());

            string_input = string_input.ToLower();
            for (i = 0; i < len; i++)
            {
                if (string_input[i] == 'a' || string_input[i] == 'e' ||
           string_input[i] == 'i' || string_input[i] == 'o' ||
            string_input[i] == 'u')
                {
                    vowels++;
                }

                //check if the character is alphabet
                else if (string_input[i] >= 'a' && string_input[i] <= 'z')
                {
                    consonants++;
                }
            }
            Console.WriteLine("The vowel number of the given string: {0}", vowels);
            Console.WriteLine("The consonant number of the given string: {0}", consonants);
            Console.ReadLine();

        }

        //Reverse the given string
        public static string StringReverse(string string_input)
        {
            char[] stringArray = string_input.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            return reversedStr;
        }
        
    }
}
