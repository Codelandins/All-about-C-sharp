namespace Methods_without_returns_in_the_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Message msg = new Message();
            //msg.texts();
            //Console.ReadKey();

            //Individuals person = new Individuals();
            //person.personlist("Mehmet");
            //person.personlist("Ozlem");
            //Console.ReadKey();

            //PeopleRegister p1 = new PeopleRegister();
            //Console.WriteLine("Enter a name and surname:");
            //string x = Console.ReadLine();
            //p1.register(x);
            //Console.ReadKey();


            Console.WriteLine("Enter first number:");
            string y = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string z= Console.ReadLine();
            operations op1 = new operations();
            op1.sum(y, z);
            op1.multipliction(y, z);    
            Console.ReadKey();


        } 
    }
}