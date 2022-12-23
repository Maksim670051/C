namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello world!!!";
            Console.WriteLine(String.Concat(s, "GGWP"));

            string[] ArrayS = s.Split(' ');
            foreach(var str in ArrayS)
                Console.WriteLine(str);

            string newS = String.Join(" ", ArrayS);
            Console.WriteLine(newS);

            Console.WriteLine(newS.Substring(0 , 5));
        }
    }
}