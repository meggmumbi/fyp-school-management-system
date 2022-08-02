using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodilityTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // MinDeletions("aaabbbcc");
            // Console.WriteLine(MinDeletions("aaabbbcc"));
            //int[] nums = new int[100000];
            //BuildArray(nums);
            //Timing tobj = new Timing();
            //tobj.StartTime();
            //DisplayNums(nums);
            //tobj.StopTime();
            // Console.WriteLine("time (.NET): " & tobj.ResultDur.TotalSeconds);
            // Console.WriteLine(RemoveDuplicateChars("aaabbbcc"));

            //check if string is anagram

            //int[,] grades = new int[, ]
            //{
            //    {1,82,74,89,100 },
            //    {2,93,96,85,86 },
            //    {3,83,72,95,89 },
            //    { 4,91,98,79,88}               
            //};
            //int total = 0;
            //double average = 0.0;
            //int last_grade = grades.GetUpperBound(1);
            //int last_student = grades.GetUpperBound(0);

            //for(int row=0; row <= last_student; row++)
            //{
            //    for (int col = 0; col <= last_grade; col++)
            //    {
            //        total += grades[row, col];
            //        average = total / last_grade;
            //        Console.WriteLine("Average: " + average);
            //    }

            //}
            //Timing sortTime = new Timing();
            //int numItems = 100;
            //CArray nums = new CArray(numItems);
            //Random rnd = new Random(100);
            //for(int i=0;i< numItems; i++)           
            //    nums.Insert((int)(rnd.NextDouble() * 100));
            //sortTime.StartTime();
            //nums.SelectionSort();
            //sortTime.StopTime();
            //Console.WriteLine("Time for selection Sort: " + sortTime.ResultDur().TotalMilliseconds);
            //nums.Clear();
            //for (int i = 0; i < numItems; i++)
            //    nums.Insert((int)(rnd.NextDouble() * 100));
            //sortTime.StartTime();
            //nums.BubbleSort();
            //sortTime.StopTime();
            //Console.WriteLine("Time for B Sort: " + sortTime.ResultDur().TotalMilliseconds);
            //nums.Clear();
            //for (int i = 0; i < numItems; i++)
            //    nums.Insert((int)(rnd.NextDouble() * 100));
            //sortTime.StartTime();
            //nums.InsertionSort();
            //sortTime.StopTime();
            //Console.WriteLine("Time for ins rt: " + sortTime.ResultDur().TotalMilliseconds);
            //nums.Clear();


            //Animal an = new Animal();
            //int total = an.Add(5, 5);
            //Console.WriteLine("Totals = " + total);

            //Car objcar = new Car();
            //objcar.color = "White";
            //objcar.model = "Suzki";
            //objcar.year = 2020;
            //Console.WriteLine(objcar.color);

            //Animal animal = new Animal();
            //Pig pig = new Pig();


            //Console.WriteLine("Enter a Number : ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //int result = Number;
            //bool isHappy;

            //while (result != 1 && result != 4)
            //{
            //    result = IsHappyNumber(result);
            //}

            //Happy number always ends with 1
            //if (result == 1)
            //    Console.WriteLine(isHappy = true);

            //Unhappy number ends in a cycle of repeating numbers which contains 4

            //else if (result == 4)
            //    Console.WriteLine(isHappy = false);

            //Console.ReadKey();
            // int[] theArray = {8,7,6,5,4,3,6};
            //Console.WriteLine(GetMax(theArray));
            //Console.ReadLine();
            //int result=0;
            //sumHashard(156);
            //1, 8, 5, 6, 10, 9, 11, 12
            // [[0,1],[0,3],[1,2],[1,3]]
            //int[] arr = { 1, 8, 5, 6, 10, 9, 11, 12 };
            //int maxChunckSorted = calcMaxChunckSorted(arr);
            //Console.WriteLine(maxChunckSorted);
            //[[0,1],[1,2],[2,3],[2,4],[5,6],[5,7]]

            //int[,] roads= new int[,] { { 0, 1 }, { 0, 3 }, { 1,2 }, { 1, 3 } };
            //int[][] table = new int[][] {
            //           new int[] { 0, 1 },
            //           new int[]{ 1, 2 },
            //           new int[]{ 2, 3 },
            //           new int[]{ 2, 4 },
            //           new int[]{ 5, 6 },
            //           new int[]{ 5, 7 }
        //};
        // int maxNet = maximalNetworkRank(8, table);
        //Console.WriteLine(maxNet);
        // int[] num = { -1, 1, -1, 1, -1 };
        //int[] A = { 10, 1, 3, 1, 2, 2, 1, 0, 4 };
        //Console.WriteLine(maxNumberIntersectingElements(A));

        //Console.WriteLine(getMaxvalue(150958));



        //Console.WriteLine("sum is "+sumHashard(156));

        //string s1, s2;
        //Console.WriteLine("Please enter string 1: ");
        //s1 = Console.ReadLine();
        //Console.WriteLine("Enter second string: ");
        //s2 = Console.ReadLine();

        //char[] a1 = s1.ToLower().ToCharArray();
        //char[] a2 = s2.ToLower().ToCharArray();

        //Array.Sort(a1);
        //Array.Sort(a2);

        //string res1 = new string(a1);
        //string res2 = new string(a2);

        //if (res1 == res2)
        //{
        //    Console.WriteLine("String is an anagram" + res1 + " " + res2);
        //}
        //else
        //{
        //    Console.WriteLine("string is not an anagram" + res1 + " " + res2);
        //}

        //string message = "Margaret Mumbi";
        //Console.WriteLine("message = {0}", message);
        //Console.WriteLine("message.Length= {0}", message.Length);

        //for (int i = 0; i < message.Length; i++)
        //{
        //    Console.WriteLine("message[{0}]={1}",i,message[i]);
        //}
        //string s1, s2;
        //Console.WriteLine("Enter First String: ");
        //s1 = Console.ReadLine();
        //Console.WriteLine("Enter second string: ");
        //s2 = Console.ReadLine();

        ////check anagram
        //int result =  s1.CompareTo(s2);


        //    Console.WriteLine(result);
        //Console.WriteLine(DateTime.Now);
        //StringBuilder sb = new StringBuilder();
        //sb.Append("Numbers: ");
        //for(int i=0; i<=200000; i++)
        //{
        //    sb.Append(i);
        //}
        //Console.WriteLine(sb.ToString().Substring(0,1024));
        //Console.WriteLine(DateTime.Now);

        //Console.WriteLine("Enter Your Name: ");
        //string name = Console.ReadLine();
        //string reversed = ReverseText(name);
        //Console.WriteLine(reversed);

        //Console.WriteLine("Enter a text");
        //string text = Console.ReadLine();
        //string reversedstring = ReverseStringExercise(text);
        //Console.WriteLine(reversedstring);

        //Stack myStack = new Stack();
        //myStack.Push("Hello");
        //myStack.Push("World";);
        //myStack.Push("!");

        ////Displays the properties and values of the stack.
        //Console.WriteLine("myStack");
        //Console.WriteLine("\tCount:  {0}", myStack.Count);
        //Console.Write("\tvalues:");
        //printvalues(myStack);
        //Write Program to find finoxcci series for given number

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", FibbonacciSeries(i));
            }
            Console.WriteLine(Environment.NewLine);

            //Console.Write("Fibbonacci Series of {0} is : {1}", 10, FibbonacciSeries1(10));

            //Console.WriteLine(Environment.NewLine);




          Console.ReadLine();
            

        }

        private static int FibbonacciSeries(int number)
        {
            int num1 = 0;
            int num2 = 1;

            for(int i = 0; i < number; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }

            return num1;
        }



        sealed class Animal
        {
            public int Add(int x, int y){
                return x + y;

                }
        }

   

        private static void DisplayNums(int[] arr)
        {
          for(int i = 0; i<=arr.GetUpperBound(0); i++)
            {
                Console.WriteLine(arr[i] + "");
            }
        }

        private static void BuildArray(int[] arr)
        {
            for(int i=0; i<=9999; i++)
            {
                arr[i] = i;
            }
        }

       

        public static void printvalues(IEnumerable mycollection)
        {
            foreach (object obj in mycollection)
                Console.Write(" {0}", obj);
            Console.WriteLine();

            
        }

        public class Collection : CollectionBase
        {
            public void Add(Object item)
            {
                InnerList.Add(item);
            }

            public void Remove(Object item)
            {
                InnerList.Remove(item);
            }

            public new int Count()
            {
                return InnerList.Count;
            }

            public new void Clear()
            {
                InnerList.Clear();
            }
        }

        public static int calcMaxChunckSorted(int[] a)
        {
           if(a.Length < 2)
            {
                return a.Length;
            }
           //store the number of chunks
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            for(int i=1; i < a.Length; i++)
            {
                if(a[i] > a[i - 1])
                {
                    stack.Push(i);
                }

                for(int j = 0;j>0 && a[j] < a[j - 1];j--)
                {
                    swap(a, j, j-1);
                    if (j <= stack.Peek())
                    {
                        stack.Pop();
                    }

                }
                
            }
            return stack.Count();

        }

        public static int maxNumberIntersectingElements(int[] A)
        {
            int n = A.Length;
            
            int ans = 0;

            for(int i=0; i < n -1 ; i++)
            {
                int sum = A[i] + A[i + 1];
                ans = Math.Max(ans, getCount(i + 1, sum, A));
                
            }
            return ans;
        }

        public static int getCount(int idx, int sum, int[] arr)
        {
            if (idx >= arr.Length-1 )
            {
                return 0;
            }

            int count = 0;
            if (arr[idx] + arr[idx + 1] == sum)
            {
                count = 1 + getCount(idx + 1, sum, arr);

            }

            return Math.Max(count, getCount(idx + 1, sum, arr));
        }

        public static void swap(int[] arr, int i,int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }


        public static int maximalNetworkRank(int n, int[][] roads)
        {
            bool[,] connected = new bool[n, n];
            int[] cnts = new int[n];
            int res = 0;


            foreach (int[] r in roads)
            {
                cnts[r[0]]++;
                cnts[r[1]]++;
                connected[r[0], r[1]] = true;
                connected[r[1], r[0]] = true;
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    res = Math.Max(res, cnts[i] + cnts[j] - (connected[i, j] ? 1 : 0));
                }
            }
            return res;




        //    int[] connections = new int[n];
        //    Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>(n);
        //    for (int i = 0; i < n; i++)
        //    {
        //        graph[i] = new HashSet<int>();
        //    }

        //    foreach (var edge in roads)
        //    {
        //        graph[edge[0]].Add(edge[1]);
        //        graph[edge[1]].Add(edge[0]);

        //        connections[edge[0]]++;
        //        connections[edge[1]]++;
        //    }

        //    int rank = 0;
        //    for (int i = 0; i < connections.Length; i++)
        //    {
        //        for (int j = i + 1; j < connections.Length; j++)
        //        {
        //            int currentRank = connections[i] + connections[j];
        //            if (graph[i].Contains(j))
        //            {
        //                currentRank--;
        //            }

        //            rank = Math.Max(rank, currentRank);
        //        }
        //    }

        //    return rank;
        //}



    }

        public static string ReverseStringExercise(string textrev)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = textrev.Length-1; i >= 0; i--)
            {
                sb.Append(textrev[i]);
            }
            return sb.ToString();
        }

        public static string BallooonReverse(string text)
        {
            StringBuilder sb = new StringBuilder();
            for(int i =0; i < text.Length; i++)
            {
                char ch = text[i];

                if (char.IsUpper(ch))
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();

        }

        public static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();            

            for(int i = text.Length-1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();

           


        }

        public static int sumHashard(int n)
        {
            int sum = 0, num = n, rem = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }


            if (n % sum == 0)
            {
                Console.WriteLine(n + " is a harshad number");
            }
            else
            {
                Console.WriteLine(n + " is not a harshad number");
            }
            return sum;

        }

    


    public static int getMaxvalue(int num)
        {
            int maxValue = int.MinValue;
            string stringNum = Convert.ToString(num);

            for(int i = 0; i < stringNum.Length; i++)
            {
                if (stringNum[i] == '5')
                {
                    string stringTocheck = stringNum.Substring(0, i) + stringNum.Substring(i + 1);
                    int IntTocheck = int.Parse(stringTocheck);
                    maxValue = IntTocheck > maxValue ? IntTocheck : maxValue;
                }

            }
            return maxValue;
            
        }
        public static int GetMaxOptimized(int[] nums)
        {

            //Dictionary<int, int> hm = new Dictionary<int, int>();
            //int result = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (hm.ContainsKey(nums[i]))
            //    {
            //        result = Math.Max(result, i - hm[(nums[i])]);
            //    }
            //    else
            //    {
            //        hm.Add(nums[i], i);
            //    }
            //}
            //return result;

            int result = 0;
            var set = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.ContainsKey(nums[i]))
                {
                    result = Math.Max(result, i - set[nums[i]]);
                }
                else
                { 
                    set.Add(nums[i], i); 
                }
            }
            return result;
        }

        public static int GetMaxNonOptimized(int[] A)
        {
            int N = A.Length;
            int result = 0;
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (A[i] == A[j])
                    {
                        Math.Max(result, Math.Abs(i - j));
                    }
                }
            }
            return result;

        }

        public static int ArraySign(int[] num)
        {
            int sign = 1;
            int prod = 1;
            foreach (int n in num)
            {

                prod = prod * n;
               
            }
            if (prod == 0)
            {
                return 0;
            }
            else if (prod < 0)
            {
                sign *= -1;
            }
            return sign;

        }

        public static int IsHappyNumber(int num)
        {
            int rem = 0;
            int sum = 0;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem);
                num = num / 10;
            }

            return sum;
        }

        public static int MinDeletions(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            //use hashset to record unique frequencies
            HashSet<int> freqSet = new HashSet<int>();
            int res = 0;

            //calculate frequencies
            int[] freq = new int[26];

            foreach (var c in s)

                freq[c - 'a']++;


            for (int i = 0; i < freq.Length; i++)
            {
                //If there is another character has the same frequency
                //We need to keep the current character until its frequency is unique
                // example 1: input is {(a,3),{b,3},{c,2},{d,2}}
                //then we need to delete 2 a or 2 b
                //example 2: input is {(a, 3), {b,3}, {c,2},{d,2}}
                //then we need to delete 2 a or 2 b, then delete 2 c or 2d\


                while (freqSet.Contains(freq[i]) && freq[i] > 0)
                {
                    freq[i]--;
                    res++;
                }
                freqSet.Add(freq[i]);

            }
            return res;
        }
        static string RemoveDuplicateChars(string key)
        {
            string result=new string(key.ToLower().Distinct().ToArray());
            //Remove duplicate chars using string concats
            //store encountered letters in this string
            //string table = "";

            ////store the result in this string
            //string result = "";

            ////loop over each character
            //foreach(char value in key)
            //{
            //    if (table.IndexOf(value) == -1)
            //    {
            //        //append to the table and the result
            //        table += value;
            //        result += value;
            //    }
            //}
            return result;
        }

       
       
            public static int[] SumZero(int n)
            {
                //Array containing n unique integers
                int[] result = new int[n];

                int num = 1;
                //Array Index
                int i = 0;
                while (i < n / 2)
                {
                    result[i] = num;
                    result[n - i - 1] = -1 * num;
                    num++;
                    i++;
                }

                //For odd add 0 as well
                if (n % 2 != 0)
                {
                    result[i++] = 0;
                }

                return result;
            }
        
    }
}
