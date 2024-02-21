﻿namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Emre Esen";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is SUPERMAN";
            bool result3 = sentence.EndsWith("e");
            bool result4= sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);
            var result10= sentence.ToLower();
            var result11= sentence.ToUpper();
            var result12= sentence.Replace(" ", "-");
            var result13= sentence.Remove(2);
            var result14 = sentence.Remove(2,5);





            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8); 
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result14);
        }

        private static void Intro()
        {
            string city = "Elazığ";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2;
            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
