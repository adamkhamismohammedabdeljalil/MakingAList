namespace MakingAList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("insert a number:");
                int number = int.Parse(Console.ReadLine());
                list.Add(number);

            }
            Console.WriteLine("The list is :");
            foreach (int number in list)
            {
                Console.WriteLine(number);
                
            }

            //print the list in a reverse order
            Console.WriteLine("Print the list in a reverse order");
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}