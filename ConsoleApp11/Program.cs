namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream file = new FileStream("info.txt", FileMode.OpenOrCreate))
            {
                string text = "Hello world !!! or mir !!!";
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                file.Write(array);
            }
            using (FileStream file = File.OpenRead("info.txt"))
            {
                byte[] array = new byte[file.Length];
                file.Read(array);
                string str = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(str);
            }
        }
    }
}