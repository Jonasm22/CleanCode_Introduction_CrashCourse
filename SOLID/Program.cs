namespace SOLID
{
    //SRP - Single Responsibility Principle
    //OCP - Open/Closed Principle
    //LSP - Liskov Substitution Principle
    //ISP - Interface Segregation Principle
    //DIP - Dependency Inversion Principle
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1, ProductName = "Laptop", Quantity = "2", Price = 600.99 };

            OrderService OrderService = new OrderService();
            
            OrderService.AddOrder(order);   

        }
    }
}
