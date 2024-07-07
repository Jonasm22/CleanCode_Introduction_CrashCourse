using System.Reflection.Emit;

namespace Special_Convention_for_naming_private_fields
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }




        class CustomerService
        {
            private string _customerName = "JohnDoe";
            public CustomerService(string customerName)
            {
                _customerName = customerName;
            }

            // bad

            public void Save()
            {
                
            }

            // Good
            public void SaveCustomer()
            {

            }public void SaveCustomerName()
            {

            }

            //much better
            //Is, Get, Set, Has, Can


            public void SetCustomerName()
            {

            }

            public bool hasErrors()
            {

                return true; 
            
            }
        }


        class OrderProcessor
        {


        }
        
       



    }
}
