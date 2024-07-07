namespace _3_LiskovSubstitutionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*Bird sparrow = new Bird();
            sparrow.Fly();

            Bird penguin = new Penguin();
            penguin.Fly();
            */

            Bird sparrow = new Sparrow();
            sparrow.MakeSound();
            ((IFlyable)sparrow).Fly();
            

            Bird penguin = new Penguin();
            penguin.MakeSound();
            


        }
    }



    public class Sparrow : Bird , IFlyable
    {
        //Contract}
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
    public class Bird
    {
       /* public virtual void Fly()
        {
            Console.WriteLine("Flying");
        }*/

        public virtual void MakeSound()
        {
            Console.WriteLine("Chrip");
        }

    }

    public class Penguin : Bird
    {
        /*public override void Fly()
        {
            throw new NotImplementedException("Penguin can not fly");

        }*/ 
        
        public override void MakeSound()
        {
           base.MakeSound();

        }





    }

    public interface IFlyable
    {
        void Fly();
    }

}
