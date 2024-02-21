namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3]; //1.yöntem
            //{
            //    students[0] = "Emre";
            //    students[1] = "Merve";
            //    students[2] = "Semra";
            //}

            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //string[] students2 = new[] {"İcardi", "Mertens", "Muslera"};  //2.yöntem

            //foreach (string student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            //string [] students3 = { "Zaha", "Tete", "Olivera" }; //3.yöntem

            //foreach (string student in students3)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[7,3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Aydın"},
                {"Van","Elazığ","Erzincan"},
                {"Hatay","Mardin","Şanlıufra"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);    
                }
                Console.WriteLine("******************");
            }





        }
    }
}
