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

            #region Q3
            // Call the PrintWelcomeMessage method in the Main method.
            PrintWelcomeMessage();
            #endregion

            #region Q4
            // Call the PrintBookTitle method in the Main method.
            PrintBookTitle("Clean Code");
            #endregion

            #region Q5
            int pages = 400;
            AddBonusPages(pages);
            // output: Total pages after bonus: 450 
            Console.WriteLine(pages);
            // output: pages after : 400 -> pass by value -> the original value is not changed. 
            //Using copy of the value of pages variable not the original.
            #endregion

            #region Q6
            double[] pricesQ06 = {25.5, 40.0};
            ApplyDiscount(pricesQ06);
            // output: 20.5 
            Console.WriteLine(pricesQ06[0]);
            // output: 20.5 -> Array reference is passed by value -> the original value is changed Cuz the reference of the array is passed to the method.
            //So the two variables pricesQ06 in the Main method and pricesQ06 in the ApplyDiscount method are pointing to the same array in memory.
            //So when we change the value of pricesQ06[0] in the ApplyDiscount method, it also changes the value of pricesQ06[0] in the Main method.
            #endregion

            #region Q7
            int pagesQ7 = 400;
            AddBonusPagesQ7(ref pagesQ7);
            // output: Total pages after bonus: 450 
            Console.WriteLine(pagesQ7);
            //Output: 450 -> pass by reference -> the original value is changed.
            //Using the original pagesQ7 variable not the copy of the value.
            //So when we change the value of pagesQ7 in the AddBonusPagesQ7 method, it also changes the value of pagesQ7 in the Main method.
            #endregion

            #region Q8
            double[] pricesQ08 = {25.5, 40.0}; 
            ReplaceArray(ref pricesQ08);
            Console.WriteLine(pricesQ08[2]);
            Console.WriteLine(pricesQ08.Length);
            // Array reference is passed by reference -> so the original array variable is updated to reference a new array.
            // output: 3 -> the original value is changed.
            #endregion

            #region Q9
            string title = "Clean Code";
            if (TryGetPrice(title, out double price))
            {
                Console.WriteLine(price);
            }
            #endregion

            #region Q10
            PrintBookInfo("Clean Code");
            // Uses the default value of pages -> 300.
            PrintBookInfo("New title" ,400);
            // Uses a specific value for pages -> 400.
            #endregion
        }

        #region Q3 Method
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion

        #region Q4 Method
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }
        #endregion

        #region Q5 Method
        public static void AddBonusPages(int pages)
        {
            pages += 50;
            Console.WriteLine($"Total pages after bonus: {pages}");
        }
        #endregion

        #region Q6 Method
        public static void ApplyDiscount(double[] pricesQ06)
        {
            pricesQ06[0] -= 5;
            Console.WriteLine(pricesQ06[0]);
        }

        #endregion

        #region Q7 Method
        public static void AddBonusPagesQ7(ref int pages)
        {
            pages += 50;
            Console.WriteLine($"Total pages after bonus: {pages}");
        }
        #endregion

        #region Q8 Method
        public static void ReplaceArray(ref double[] pricesQ08)
        {
            double[] newPrices = {10.0, 12.5, 15.0};
            pricesQ08 = newPrices;
        }
        #endregion

        #region Q9 Method
        public static bool TryGetPrice(string title, out double price)
        { 
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0.0;
                return false;
            }
        }
        #endregion

        #region Q10 Method
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"The title is: {title} and num of Pages  is : {pages}");
        }
        #endregion
    }
}
