namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //classın örneği oluşturuldu.Class oluşturulurken PascalCase onun örneğinde camelCase olur...
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName= "Emre";
            customer.LastName = "Esen";
            customer.City = "İstanbul";
            customer.Id = 23;

            Customer customer1 = new Customer
            {
               Id = 2, FirstName= "Merve", LastName="Esen", City="Elazığ"  
            };

            Console.WriteLine(customer1.FirstName);


        }
    }

    

   
}
