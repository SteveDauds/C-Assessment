using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uncomment each question to run

            ////Question1
            //Console.Write("Enter Your Text: ");
            //string text = Console.ReadLine();
            //char[] char_text = text.ToLower().ToCharArray();
            //int count = 1, myInt;
            //if (int.TryParse(text, out myInt))
            //{
            //    Console.WriteLine("You entered an invalid value");
            //}
            //else
            //{
            //    for (int i = 0; i < char_text.Length; i++)
            //    {
            //        if (char_text[i] == '\0')
            //        {
            //            continue;
            //        }
            //        for (int j = i + 1; j < char_text.Length; j++)
            //        {
            //            if (char_text[i] != '\0' && char_text[j] != '\0')
            //            {
            //                if (char_text[i] == char_text[j])
            //                {
            //                    char_text[j] = '\0';
            //                    count++;
            //                }

            //            }
            //        }
            //        Console.WriteLine("Character " + char_text[i] + ": " + count + " times");
            //        count = 1;
            //        char_text[i] = '\0';
            //    }
            //}

            ////Question 2
            //List<string> cityNames = new List<string>()
            //{
            //    "Nairobi", "Zurich", "London", "New Delhi", "Rome", "California", "Paris", "Abu Dhabi", "Amsterdam"
            //};
            //List<string> sortCityNames = cityNames.OrderBy(city => city.Length).ThenBy(city => city).ToList();
            //foreach (string cityName in sortCityNames)
            //{
            //    Console.WriteLine(cityName);
            //}


            //Question 3
            //string exchange, newString = "";
            //char lastLetter, firstLetter;
            //Console.Write("Enter Your Text: ");
            //exchange = Console.ReadLine();
            //char[] char_array = exchange.ToCharArray();
            //if(exchange == "")
            //{
            //    Console.WriteLine("You did not enter any text");
            //}
            //else if(exchange.Length == 1)
            //{
            //    newString = exchange;
            //}
            //else if(exchange.Length == 2)
            //{
            //    Array.Reverse(char_array);
            //    newString = new string(char_array);
            //}
            //else
            //{
            //    firstLetter = char_array[0];
            //    lastLetter = char_array[exchange.Length - 1];

            //    for(int i = 0; i < exchange.Length; i++)
            //    {
            //        if(i == 0)
            //        {
            //            newString += lastLetter;
            //        }
            //        else if(i == char_array.Length - 1)
            //        {
            //            newString += firstLetter;
            //        }
            //        else
            //        { 
            //            newString += char_array[i];
            //        }
            //    }
            //}
            //Console.WriteLine(newString);

            ////Question4
            //try
            //{
            //    Console.Write("Enter a Letter: ");
            //    char letter = Convert.ToChar(Console.ReadLine().ToLower());
            //    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        Console.WriteLine("The alphabet is a vowel");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The alphabet is a consonant");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Invalid Entry");
            //}

            Console.ReadKey();
        }
    }
}
