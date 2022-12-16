namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new("fff@gmail.com", "Password12");
            user.FullName = "xD";
            
            User user2 = new("ccc@gmail.com", "Password12");
            user.FullName = "xD";
            
            User user3 = new("ddd@gmail.com", "Password12");
            user.FullName = "xD";


            //user.ShowInfo();
            //user2.ShowInfo();
            //user3.ShowInfo();

            Console.WriteLine($"{user}\n{user2}\n{user3}");
        }
    }
}