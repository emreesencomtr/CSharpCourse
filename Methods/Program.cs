namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Add();
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(10, 23);

            //var result = Add2(20);

            //int number1 = 20;
            //int number2 = 100;  
            //var result2 = Add3(out number1,number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(1,2,3,4,8,6,7));   //params olduğundan dolayı istediğin kadar değer yollayabilirsin


        }

        static void Add()
        {
            Console.WriteLine("Added!!!!!");

        }

        static int Add2(int number1, int number2=30) //numbera değer verilemezse defaut değer olarak 30'u kullan demektir.
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(out int number1, int number2)  //refans tiple gönderildi. iki tarafın başına da ref olması gerekmektedir.
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2*number3;
        }


        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
