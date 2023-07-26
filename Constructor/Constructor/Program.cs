namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(); //That is really enough to see the result
                                         //We do not need to write that stu.Student()
            Console.Read();

            Identity p1 = new Identity();
            p1.NAME = "Mehmet";
            p1.SURNAME = "kiroglu";
            p1.NATIONALITY = "BALIKESIR";
            Console.WriteLine(p1.NAME);
            Console.WriteLine(p1.SURNAME);
            Console.WriteLine(p1.NATIONALITY);
            Console.WriteLine(p1.AGE);
            Console.WriteLine(p1.GENDER);
            Console.Read();
        }
    }
}