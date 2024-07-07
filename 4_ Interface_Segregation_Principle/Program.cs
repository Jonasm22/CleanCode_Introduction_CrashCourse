namespace _4__Interface_Segregation_Principle
{

    // interface segregation principle (ISP)
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 METHODE
            /*
            IWorkable human = new Worker();
            ((IEateable)human).Eat(); 

            IWorkable robot = new Robot();  
            robot.Work();7
            */
            

            // 2 METHODE

            Worker human = new Worker();
            human.Work();
            human.Eat();

            Robot robot = new Robot();
            robot.Work();
            


            /*
            try
            {
                robot.Eat();
            }
            catch (NotImplementedException ex)
            {

                Console.WriteLine(ex.Message);
            }
            */




        }



        public interface IWorkable
        {
            void Work();

        }


        public interface IEateable
        {
            void Eat();

        }


        public class Worker : IWorkable , IEateable
        {
            public void Work()
            {
                Console.WriteLine("Working");
            }

            public void Eat()
            {
                Console.WriteLine("Eating");
            }

        }public class Robot : IWorkable 
        {
            public void Work()
            {
                Console.WriteLine("Working");
            }


            // remove

            /*
            public void Eat()
            {
                // Robot do not eat, but are forced to implement this method
                
                Console.WriteLine("Eating");
            
                throw new NotImplementedException();
            }
            */
        }

    }

}
