using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {


            //Question 1
            Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintTriangle(n);
            //Console.WriteLine();

            //Question 2:
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            PrintPellSeries(n2);
            Console.WriteLine();

            //Question 3
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            bool flag = SquareSums(n3);
            if (flag)
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }

            //Question 4:
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int n4 = diffPairs(arr, k);
            Console.WriteLine("There exists {0} pairs with the given difference", n4);

            //Question 5:
            List<string> emails = new List<string>();
            emails.Add("dis.email+bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is "+ ans5);

            //Quesiton 6:
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                            { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);

        }
        private static void PrintTriangle(int n)
        {
            try
            {
                // different data types where a= row,b=symbol,c=space
                int a, b, c;

                // using for loop for printing n number of rows
                for (a = 1; a <= n; a++)
                {
                    // Function to print the c(space)
                    for (c = 1; c <= (n - a); c++)
                    {
                        Console.Write(" ");
                    }
                    // Function to print the pattern (formula)
                    for (b = 1; b <= ((2 * a) - 1); b++)
                    {
                        Console.Write("*");
                    }
                    // Function to print the next row in a new line 
                    Console.WriteLine();


                }
                Console.ReadLine();


            }
            catch (Exception)
            {

                throw;
            }

        }

        private static void PrintPellSeries(int n2)
        {
            try
            {
                // Integer variables 
                int p = 0;
                int q = 1;
                int r = 0;
                int num;



                Console.WriteLine(r);
                Console.WriteLine(q);



                //For condition 
                for (num = 1; num <= 8; num++)

                {
                    // formula for writing the series
                    r = p + (2 * q);
                    Console.WriteLine(r);


                    p = q;
                    q = r;



                }
                // to read theline 
                Console.ReadLine();


            }
            catch (Exception)
            {

                throw;
            }

        }

        private static bool SquareSums(int n3)
        {
            try
            {
                // implimentation of For Loop 
                for (int p = 0; p * p <= n3; p++)
                    for (int q = 0; q <= n3; q++)

                        //Logic for equating the sum 
                        if (p * p + q * q == n3)
                        {
                            return true;

                        }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }


        private static int diffPairs(int[] nums, int k)
        {
            try
            {
                // to print different pairs in array  for the input k
                int num = nums.Length;
                int count = 0;
                for (int a = 0; a< num; a++)
                {
                    //using for loop to get the difference 
                    for (int b = a + 1; b < num; b++)
                        if (nums[a] - nums[b] == k ||
                              nums[b] - nums[a] == k)
                            count++;
                }

                return count;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        private static int UniqueEmails(List<string> emails)
        {
            try
            {
                //creating a new list to store emails
                var filteredList = new List<string>();
                //for each email
                foreach (var email in emails)
                {
                    int indexOfAt = email.IndexOf('@');
                    string localName = email.Substring(0, indexOfAt);
                    string domainName = email.Substring(indexOfAt);

                    //clean local name
                    localName = localName.Replace(".", "");

                    //everything after + sign will be ignored 
                    var indexOfPlus = localName.IndexOf("+");
                    localName = localName.Substring(0, indexOfPlus);
                    
                    //adding of emails 
                    filteredList.Add(localName + domainName);
                }
                var uniqueEmails = filteredList.Distinct().Count();
                return uniqueEmails;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            
        }

        private static string DestCity(string[,] paths)
        {
            var fromCities = new List<string>();
            var toCities = new List<string>();

            for (int i = 0; i < paths.GetLength(0); i++)
            {
                //getting from cities
                var fromCity = paths[i, 0];
                fromCities.Add(fromCity);

                //getting to cities
                var toCity = paths[i, 1];
                toCities.Add(toCity);
            }

            foreach (var toCity in toCities)
            {
                //if to city is not in from city list, it is destination
                if (!fromCities.Contains(toCity))
                {
                    return toCity;
                }
            }
            return "";
        }



    }
}
 
 
/*Self - reflection:
         1.learning C# basics is important like,
          - Iterative statements
          - Conditional statements
          - about Array
          - Method declaration and calling
         2. This assignment was helpful for me to understand about the errors and different ways to solve them 
       
         Recommendations:
         1.More questions on topic arrays would be great.
         2.Instead of triangle with *, a triangle with number series (numbers) would have been more interesting. */