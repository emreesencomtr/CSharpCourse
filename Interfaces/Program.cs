namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterFacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterFacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Merve",
                Lastname = "Esen",
                Adress = "Elazığ"

            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Emre",
                Lastname = "Esen",
                Departmant = "Computer Sciences"

            };
            manager.Add(customer);
            manager.Add(student);
        }
    }

    interface Iperson
    {
        int Id { get; set; }
        string FirstName { get; set; }

        string Lastname { get; set; }
    }

    class Customer : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public string Adress { get; set; }
    }

    class Student : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(Iperson person )
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
