namespace LineComparisionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Computation Program");
            Console.WriteLine("Choose Option\n 1.Length Of A Line\t 2.Equality of two lines");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    LengthOfaLine.CalculateLength();
                    break;
                    case 2:
                    EqualityOfTwoLines.Equality();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Choice");
                    break;
            }
        }
    }
}