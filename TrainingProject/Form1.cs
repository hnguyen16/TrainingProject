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
            Say("BT is awesome!");

            Environment.Exit(-1);
        }

        public void Say(string s)
        {
            Console.WriteLine(s);
        }


        public void PracticeLoops()
        {
            List<int> intList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> intList2 = new List<int>();

            // TODO:  Write a loop to add 1 to each value, then print each element to console.  


            // TODO:  Write a loop to print values backward.


            //  TODO: Populate intList2 values n+5 from intList1. 

        }


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
