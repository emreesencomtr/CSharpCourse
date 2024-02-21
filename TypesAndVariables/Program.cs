namespace TypesAndVariables
{
    internal class Program
    {
        private static object console;

        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello, World!");
            int number1 = 10;
            long number2 = 21474836478;
            short number3 = -32768;
            byte number4 = 23; //en küçük 0-255 arasında veri tutar
            bool condition = false;
            char character = 'A'; //ASCII 
            double number5 = 10.4;
            decimal number6 = 10.4572m; //virgülden sonra 25-26
            var number7 = 10;
            number7 = 'A';

                       

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(condition);
            Console.WriteLine(character);
            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine(Days.Monday);
            Console.WriteLine(number7);




        }

    } enum Days
    {
        Monday, Tuesday,Wednesday, Friday, Saturday,Sunday
    }

    
}
