using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C50_GSatTue_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             * Q1 - Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75.
             * Print the second price (index 1).
             */
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion

            #region Q2
            /*
             * Q2 - Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies
             * and shelf 1 has 1, 4 copies.
             * Print the number of copies on shelf 1, slot 0.
             */
            //int[,] shelfCopies =
            //{
            //   { 3 , 5 },
            //   { 1 , 4 }
            //};
            //Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region Q3
            /*
             * Q3 - Write a method called PrintWelcomeMessage that takes no parameters and prints
             * "Welcome to the Library!". Call it from Main.
             */
            //PrintWelcomeMessage();


            #endregion

            #region Q4
            /*
             * Q4 - Write a method PrintBookTitle(string title) that prints "Book title: " + title.
             * Call it with "Clean Code".
             */
            //PrintBookTitle("Clean Code");



            #endregion

            #region Q5
            /*
             * Q5 - Write a method AddBonusPages(int pages) that adds 50 to pages.
             * Call it with a variable int pages = 400; and print pages afterward.
             * What do you expect to see, and why?
             */
            // i exepect no change. pages still 400;
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            #endregion

            #region Q6
            /*
             * Q6 - Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].
             * Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.
             * What do you expect to see, and why?
             */
            //prices[0] will be 20,5
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);


            #endregion

            #region Q7
            /*
             * Q7 - Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
             * Call it and print pages afterward.
             * How is the result different from question 5?
             */
            // pages had changed . what happend in the method for the variable pages happend to it also
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);

            #endregion

            #region Q8
            /*
             * Q8 - Write a method ReplaceArray(ref double[] prices) that replaces prices entirely
             * with a new array { 10.0, 12.5, 15.0 }.
             * Call it with your prices array and print prices.Length afterward.
             */
            //double[] arr = new double[1];
            //ReplaceArray(ref arr);
            //Console.WriteLine(arr.Length);



            #endregion

            #region Q9
            /*
             * Q9 - Write a method bool TryGetPrice(string title, out double price) that returns true
             * and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.
             * Call it and print the price if found.
             */
            //bool b =  TryGetPrice("Clean Code", out double price);
            //if(b) Console.WriteLine(price);

            #endregion

            #region Q10
            /*
             * Q10 - Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.
             * Call it once with only a title, and once passing both a title and pages.
             */
            //int pages = 1000;
            //string title = "Meow";
            //PrintBookInfo( title);
            //PrintBookInfo( title , pages);

            #endregion

            #region Q11
            /*
             * Q11 - Using the PrintBookInfo method from the question above, call it by naming the
             * parameters, passing pages before title.
             */
            //int pages = 1000;
            //string title = "Meow";
            //PrintBookInfo(pages: pages, title : title);

            #endregion

            #region Q12
            /*
             * Q12 - Write a method PrintAllTitles(params string[] titles) that prints each title
             * on its own line. Call it with three book titles.
             */
             //PrintAllTitles("Book1", "Book2", "Book3");
            #endregion
        }

        // Q3
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}

        // Q4
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}

        // Q5
        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}

        // Q6
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;

        //}

        // Q7
        //static void AddBonusPagesByRef(ref int pages)
        // {
        //     pages += 50;
        // }

        // Q8
        //static void ReplaceArray(ref double[] arr)
        //{
        //    arr = new double[] { 10.0, 12.5, 15.0 };
        ////     another way
        ////    arr = [ 10.0 , 12.5, 15.0 ];
        //}

        // Q9
        //static bool TryGetPrice (string title,out double price)
        //{
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }else
        //    {
        //        price = 0;
        //        return false;
        //    }
        //}

        // Q10 && Q11
        //static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($" title: {title} , pages: {pages}");
        //}

        // Q12
        //static void PrintAllTitles(params string[] titles)
        //{
        //    foreach(string title in titles){
        //        Console.WriteLine(title);
        //    }
        //}


    }
}
