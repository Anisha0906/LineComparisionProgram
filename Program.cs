namespace LineComparisionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Computation Program");
            Console.WriteLine("Choose Option\n 1.Length Of A Line");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    LengthOfaLine.CalculateLength();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Choice");
                    break;
            }
        }
    }
}