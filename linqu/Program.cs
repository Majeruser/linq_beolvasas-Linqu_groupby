namespace linqu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Model model = new Model();
            foreach(KeyValuePair<string,int> item in model.publisherCount())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            foreach (KeyValuePair<string, int> item in model.GenreCount())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
