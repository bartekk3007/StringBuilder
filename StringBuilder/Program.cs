using System.Text;

namespace StringBuilding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                stringBuilder.Append($"{i.ToString()}\t");
            }
            string result = stringBuilder.ToString();
            Console.WriteLine(result);
        }
    }
}
