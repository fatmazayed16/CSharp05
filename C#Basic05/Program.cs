namespace C_Basic05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"the second price is {prices[1]}");
            #endregion

            #region Q2
            int[,] shelfCopies = { { 3,5 },{1,4 } };
            Console.WriteLine(shelfCopies[1,0]);
            #endregion
        }
    }
}
