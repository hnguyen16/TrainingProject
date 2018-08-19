using System;
using System.Collections.Generic;
using TrainingProject.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //  This is how you print to console. 
            //Say("BT is awesome!");
            //PracticeLoops();

            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6 };
            intList = addOneToElements(intList);

            Console.WriteLine(addToOneHundred(1));
            string s = "abcba";
            Console.WriteLine(isPalindromeRecursive(s, 0,s.Length-1));

            //Console.WriteLine(say);
            Environment.Exit(-1);
        }

        public List<int> addOneToElements(List<int> t) {

            for (int i =0; i<t.Count; i++) {
                t[i] = t[i] + 1;
            }

            return t;
        }

        public bool isPalindromeRecursive(string s, int i, int j)
        {         
            if (s[i].Equals(s[j])){
                if (i < j)
                {
                    i++; j--;
                    return isPalindromeRecursive(s, i, j);
                }

                return true;
            }

            return false;
        }

        public int addToOneHundred(int num) {
            num++;  //manipulate code

            if (num < 100) //end condition
            {
                return addToOneHundred(num);
            }

            return num;
        }

        public void Say(string s)
        {
            Console.WriteLine(s);
        }


        //public void PracticeLoops()
        //{
        //    List<int> intList1 = new List<int>();

        //    for (int i =100; i >=1; i--) {
        //        intList1.Add(i);
        //        //Console.WriteLine(i);
        //    }
        //    Console.WriteLine("second loop");
        //    for (int i = 0; i<intList1.Count(); i++) {
        //        if (intList1[i] == 5) break;
        //    }

        //    int t = 0; // last index of intList1
        //    while (intList1[t] >=5)
        //    {
        //        //Console.WriteLine(intList1[t]);
        //        t++;
        //    }

        //    Console.WriteLine("Third Loop");
        //    int listCount = intList1.Count();
        //    int lastIndex = listCount - 1;
        //    int b = 0;
        //    while (b <= lastIndex) {
        //        if (b != lastIndex)
        //        {
        //            intList1[b] = intList1[b] + intList1[b + 1];
        //            Console.WriteLine(intList1[b]);
        //            b++;
        //        }
        //        else {
        //            Console.WriteLine("self destruct");
        //            b++;
        //        };
                
        //    }

        //    Console.WriteLine("loop four");
        //    foreach(int value in intList1)
        //    {
        //        Console.WriteLine(value);

        //    }

        //    for(int j = 0; j < intList1.Count(); j++)
        //    {
        //        Boolean indexIsOdd = false;
        //        indexIsOdd = isOdd(j);

        //        if (isOdd(j)) {
        //            Console.WriteLine(intList1[j]);
        //        }
        //        else{
        //            Console.WriteLine("Indes is even");
        //        }
        //    }


            
        //    //  TODO: Populate intList2 values n+5 from intList1. 

        //}

        //public bool isPalindrome(String palindrome) {
        //    //int i = 0;
        //    //int j = palindrome.Length-1;
        //    int j = palindrome.Length - 1 ;
        //    int innnerIndex = j;
        //    for (int i = 0; i < j; i++)
        //    {
        //        for (j = innnerIndex; j < palindrome.Length; j--)
        //        {
        //            char b = palindrome[i];
        //            char c = palindrome[j];

        //            if (!palindrome[i].Equals(palindrome[j]))
        //            {
        //                return false;
        //            }
        //            innnerIndex--;
        //            break;
        //        }
        //    }
        //    return true;
        //}

        //public Boolean isOdd(int num) {

        //    if (num % 2 == 0) {
        //        return true;
        //    }
        //    return false;
        //}

        public void PracticeOOP()
        {
            //  Instantiate new people object. 
            //  name = Thi, age = 1000, weight = 200, spouse = ChunChun, numList = list with value 1,2,3,4,5,6,7,8,9,10


            //  Instantiate new people object. 
            //  name = ChunChun, age = 2000, weight = 20, spouse = Thi, numList = list with value 10,9,8,7,6,5,4,3,2,1


            //  Create a list and add these two People to the list. 


            //  TODO: loop through your list of people and set Thi's age to 10, print out his age. 

            //  TODO:  Set up recursion method to remove values from list
            //  I will have to explain this one to you.  
        }

    }
}
