using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TechgigPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            //string input = Console.ReadLine();
            //Console.WriteLine("Hello Techgig");
            //Console.WriteLine(input);

            #endregion

            #region Problem 2

            //string input = Console.ReadLine();
            //int rint;
            //float rfloat;
            //if (int.TryParse(input, out rint))
            //    Console.WriteLine("This input is of type Integer.");
            //else if (float.TryParse(input, out rfloat))
            //    Console.WriteLine("This input is of type Float.");
            //else if (!string.IsNullOrWhiteSpace(input))
            //    Console.WriteLine("This input is of type String.");
            //else
            //    Console.WriteLine("This is something else.");

            #endregion

            #region Problem 3

            //double p = Convert.ToDouble(Console.ReadLine());
            //int i = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //double Interest = (p * i * y) / 100;
            //Console.WriteLine(Math.Round(Interest));

            #endregion

            #region Problem 4

            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age < 10)
            //    Console.WriteLine("I am happy as having no responsibilities.");
            //else if (age >= 10 && age < 18)
            //    Console.WriteLine("I am still happy but starts feeling pressure of life.");
            //else
            //    Console.WriteLine("I am very much happy as i handled the pressure very well.");

            #endregion

            #region Problem 5

            //int number = Convert.ToInt32(Console.ReadLine());
            //int fact = 1;
            //while (number > 1)
            //{
            //    fact = fact * number;
            //    number--;
            //}

            //Console.WriteLine(fact);

            #endregion

            #region Problem 6

            //int input = Convert.ToInt32(Console.ReadLine());
            //int count = 0;

            //while (input > 0)
            //{
            //    input = input / 10;
            //    count++;
            //}

            //Console.WriteLine(count);

            #endregion

            #region Problem 7

            //int one = Convert.ToInt32(Console.ReadLine());
            //int two = Convert.ToInt32(Console.ReadLine());
            //bool isPrime = true;
            //int count = 0;
            //for (int i = one; i < two; i++)
            //{
            //    isPrime = true;
            //    for (int j = 2; j <= i; j++)
            //    {
            //        if (i % j == 0 && i != j)
            //        {
            //            isPrime = false;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(count);

            #endregion

            #region Problem 8

            //int a0, a1, a2;
            //int b0, b1, b2;
            //a0 = 10; a1 = 15; a2 = 20;
            //b0 = 5; b1 = 6; b2 = 7;

            //int aliceScore = 0, bobScore = 0;
            //if (a0 > b0) aliceScore++;
            //if (a1 > b1) aliceScore++;
            //if (a2 > b2) aliceScore++;
            //if (a0 < b0) bobScore++;
            //if (a1 < b1) bobScore++;
            //if (a2 < b2) bobScore++;
            //if (a0 == b0 || a1 == b1 || a2 == b2)
            //{
            //    aliceScore += 0;
            //    bobScore += 0;
            //}

            //int[] values = new int[2];
            //values[0] = aliceScore;
            //values[1] = bobScore;

            #endregion

            #region Problem 9

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[][] a = new int[n][];
            //for (int a_i = 0; a_i < n; a_i++)
            //{
            //    string[] a_temp = Console.ReadLine().Split(' ');
            //    a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            //}

            //int sumTopToBottom = 0, sumBottomToTop = 0;
            //int left = 0, right = n - 1;
            //while (n > 0)
            //{
            //    sumTopToBottom += a[left][left];
            //    sumBottomToTop += a[left][right];
            //    left++;
            //    right--;
            //    n--;
            //}

            //int result = sumTopToBottom - sumBottomToTop;
            //result = result < 0 ? -1 * result : result;


            #endregion

            #region Problem 10

            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            //decimal negative = 0, positive = 0, zero = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > 0)
            //        positive++;
            //    else if (arr[i] < 0)
            //        negative++;
            //    else
            //        zero++;
            //}

            //Console.WriteLine(positive / n);
            //Console.WriteLine(negative / n);
            //Console.WriteLine(zero / n);          

            #endregion

            #region Problem 11
            /*  #
               ## 
              ###
             ####
            #####
           ######
             */
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n - i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write("#");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Problem 12

            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            //long[] sumN = new long[arr.Length];
            //long sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (i != j)
            //        {
            //            sum += arr[j];
            //        }
            //    }

            //    sumN[i] = sum;
            //    sum = 0;
            //}

            //Console.WriteLine(string.Format("{0} {1}", sumN.Min(), sumN.Max()));

            #endregion

            #region Problem 13

            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ar_temp = Console.ReadLine().Split(' ');
            //int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);

            //var re = (from g in ar
            //          group g by g into grp
            //          select new
            //          {
            //              Key = grp.Key,
            //              Value = grp.Count()
            //          }).OrderByDescending(item => item.Value).First();

            //Console.WriteLine(re.Value);

            // 3 2 1 3 // 2 2 1 3
            // 3 2 1 3 // 2 2 1 3
            //int num = ar[0];
            //int count = 1;
            //for (int i = 1; i < n; i++)
            //{
            //    if (num == ar[i])
            //    {
            //        count++;
            //    }
            //    else if (num > ar[i])
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        num = ar[i];
            //        count = 1;
            //    }
            //}

            //Console.WriteLine(count);

            #endregion

            #region Problem 14

            //string input = Console.ReadLine();

            //TimeSpan date = Convert.ToDateTime(input).TimeOfDay;

            //string h = date.Hours.ToString();
            //string m = date.Minutes.ToString();
            //string s = date.Seconds.ToString();

            //while (h.Length < 2)
            //{
            //    h = "0" + h;
            //}

            //while (m.Length < 2)
            //{
            //    m = "0" + m;
            //}

            //while (s.Length < 2)
            //{
            //    s = "0" + s;
            //}

            //Console.WriteLine(h + ":" + m + ":" + s);

            #endregion

            #region Problem 15

            //int n = Convert.ToInt32(Console.ReadLine());
            //decimal[] grades = new decimal[n];
            //int[] updatedgrades = new int[n];

            //for (int grades_i = 0; grades_i < n; grades_i++)
            //{
            //    grades[grades_i] = Convert.ToDecimal(Console.ReadLine());
            //}

            //int nearestRoundoff;

            //for (int index = 0; index < grades.Length; index++)
            //{
            //    if (grades[index] < 38)
            //    {
            //        updatedgrades[index] = Convert.ToInt32(grades[index]);
            //    }
            //    else
            //    {
            //        nearestRoundoff = Convert.ToInt32(5 * Math.Ceiling(Convert.ToDecimal(Math.Abs(grades[index] / 5))));
            //        if ((nearestRoundoff - grades[index]) < 3)
            //        {
            //            updatedgrades[index] = nearestRoundoff;
            //        }
            //        else
            //            updatedgrades[index] = Convert.ToInt32(grades[index]);
            //    }
            //}

            //for (int grades_i = 0; grades_i < updatedgrades.Length; grades_i++)
            //{
            //    Console.WriteLine(updatedgrades[grades_i]);
            //}

            #endregion

            #region Problem 16
            //     3     5    6      7          9   11          15        20
            //  --a3-----a---a1----a2,s--------b1---t-----------b---------b2----   

            //int s = 7; //house left position
            //int t = 11; // house right position
            //int a = 5;  // apple tree position
            //int b = 15; //orange tree position
            //int m = 3; // count of apples
            //int n = 2; // count of oranges

            //int[] apple = { -2, 2, 1 };
            //int[] orange = { 5, -6 };

            ////get Apples position
            //int[] applesPos = new int[m];
            ////get Orange position
            //int[] orangePos = new int[n];

            //for (int i = 0; i < apple.Length; i++)
            //{
            //    applesPos[i] = a + apple[i];
            //}

            //int appleC = (from ap in applesPos
            //              where ap >= s
            //              select ap).Count();

            //for (int i = 0; i < orange.Length; i++)
            //{
            //    orangePos[i] = b + orange[i];
            //}

            //int orangeC = (from op in orangePos
            //               where op <= t
            //              select op).Count();

            //Console.WriteLine(appleC);
            //Console.WriteLine(orangeC);

            #endregion

            #region Problem 17

            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] unsorted = new string[n];
            //for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
            //{
            //    unsorted[unsorted_i] = Console.ReadLine();
            //}
            //string temp = "";
            ////20 1
            //int k;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (unsorted[i].Length > unsorted[j].Length)
            //        {
            //            temp = unsorted[j];
            //            unsorted[j] = unsorted[i];
            //            unsorted[i] = temp;
            //        }

            //        if (unsorted[i].Length == unsorted[j].Length)
            //        {
            //            int len = unsorted[i].Length;
            //            k = 0;
            //            while (k < len && unsorted[i][k] >= unsorted[j][k])
            //            {
            //                if (unsorted[i][k] == unsorted[j][k])
            //                {
            //                    k++;
            //                    continue;
            //                }
            //                else
            //                {
            //                    temp = unsorted[j];
            //                    unsorted[j] = unsorted[i];
            //                    unsorted[i] = temp;
            //                    k++;
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("--------------------------");
            //for (int i = 0; i < unsorted.Length; i++)
            //{
            //    Console.WriteLine(unsorted[i]);
            //}

            #endregion

            #region Problem 18

            //int _ar_size;
            //_ar_size = Convert.ToInt32(Console.ReadLine());
            //int[] _ar = new int[_ar_size];
            //String elements = Console.ReadLine();
            //String[] split_elements = elements.Split(' ');
            //for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            //{
            //    _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            //}
            //int temp;
            ////6
            ////4 1 3 5 6 2


            //for (int i = 0; i < _ar_size; i++)
            //{
            //    for (int j = i + 1; j < _ar_size; j++)
            //    {
            //        if (_ar[i] > _ar[j])
            //        {
            //            temp = _ar[i];
            //            _ar[i] = _ar[j];
            //            _ar[j] = temp;
            //        }

            //        Console.Write(_ar[j]);
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Problem 19

            //StringBuilder strBuilder = new StringBuilder();
            //int[] ar = { 1, 4, 3, 2 };
            //int len = 4;
            //for (int i = len - 1; i >= 0; i--)
            //{
            //    strBuilder.Append(ar[i]);
            //    strBuilder.Append(" ");
            //}

            //Console.WriteLine(strBuilder.ToString().Trim());

            #endregion


            #region Problem 20

            //int i = 4;
            //double d = 4.0;
            //string s = "HackerRank ";

            //int input = Convert.ToInt32(Console.ReadLine());
            //double inputD = Convert.ToDouble(Console.ReadLine());           
            //inputD = d + inputD;
            //string inputS = Console.ReadLine();            

            //Console.WriteLine(input + i);    
            //Console.WriteLine(inputD.ToString("0.0"));
            //Console.WriteLine(s + " " + inputS);

            #endregion

            #region Problem 21

            //double mealCost = Convert.ToDouble(Console.ReadLine());
            //int tipPercent = Convert.ToInt32(Console.ReadLine());
            //int taxPercent = Convert.ToInt32(Console.ReadLine());

            //double tip = (mealCost * tipPercent) / 100;
            //double tax = (mealCost * taxPercent) / 100;
            //double totalCost = mealCost + tip + tax;

            //Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(totalCost));

            #endregion

            #region Problem 22

            //int input = Convert.ToInt32(Console.ReadLine());

            //bool isEven = input % 2 == 0;

            //if (!isEven)
            //{
            //    Console.WriteLine("Weird");
            //}
            //else if (input >= 2 && input <= 5)
            //{
            //    Console.WriteLine("Not Weird");
            //}
            //else if(input >=6 && input <=20)
            //{
            //    Console.WriteLine("Weird");
            //}
            //else if(input > 20)
            //{
            //    Console.WriteLine("Not Weird");
            //}

            #endregion

            #region Problem 23

            //int T = int.Parse(Console.In.ReadLine());
            //int[] ar = new int[T];
            //for (int i = 0; i < T; i++)
            //{
            //    ar[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < T; i++)
            //{
            //    int age = ar[i];
            //    Person p = new Person(age);
            //    p.amIOld();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        p.yearPasses();
            //    }
            //    p.amIOld();
            //    Console.WriteLine();
            //}

            #endregion

            #region Problem 24

            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
            //}

            #endregion

            #region Problem 25

            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] strArray = new string[n];

            //for (int i = 0; i < n; i++)
            //{
            //    strArray[i] = Console.ReadLine();
            //}
            //char[] cArray;
            //for (int i = 0; i < n; i++)
            //{
            //    cArray = strArray[i].ToCharArray();
            //    for (int k = 0; k < cArray.Length; k++)
            //    {
            //        Console.Write(cArray[k]);
            //        k++;
            //    }
            //    Console.Write(" ");
            //    for (int j = 1; j < cArray.Length; j++)
            //    {
            //        Console.Write(cArray[j]);
            //        j++;
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Problem 26

            string str = "aabaa";
            int len = str.Length;
            List<string> subStr = new List<string>();

            for (int i = 0; i < len; i++)
            {
                for (int j = 1; j < len - i; j++)
                {
                    subStr.Add(str.Substring(i, j));
                }
            }

            for (int i = 0; i < subStr.Count; i++)
            {
                Console.WriteLine(subStr[i]);
            }


            //string[] tokens_n = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(tokens_n[0]);
            //int q = Convert.ToInt32(tokens_n[1]);
            //string s = Console.ReadLine();
            //for (int a0 = 0; a0 < q; a0++)
            //{
            //    string[] tokens_left = Console.ReadLine().Split(' ');
            //    int left = Convert.ToInt32(tokens_left[0]);
            //    int right = Convert.ToInt32(tokens_left[1]);
            //    //string[] strArray = new string[10];

            //    for (int i = left; i <= right; i++)
            //    {
            //        for (int j = left + 1; j <= right; j++)
            //        {

            //        }
            //    }
            //}

            #endregion

            Console.ReadLine();
        }

    }

    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            age = initialAge;
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }
        public void amIOld()
        {
            if (age < 13)
                Console.WriteLine("You are Young.");
            else if (age >= 13 && age < 18)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are old.");
        }

        public void yearPasses()
        {
            age++;
        }
    }
}
