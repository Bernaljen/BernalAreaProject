namespace BernalAreaProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int length;
            int width;


            int area;

            Console.Write("Enter Length:");
            length = int.Parse(Console.ReadLine());

            Console.Write("Enter width:");
            width = int.Parse(Console.ReadLine());

            area = (length * width);

            Console.WriteLine($"area: {area}");



        }
    }
}