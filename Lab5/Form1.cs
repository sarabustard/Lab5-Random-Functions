using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: Sara
         * Date: November 2024
         * This program rolls one dice or calculates mark stats.
         * Link to your repo in GitHub: 
         * */

        //class-level random object
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //select one roll radiobutton
            radOneRoll.Select();

            //add your name to end of form title
            this.Text = this.Text + "  - Sara Bustard";



        } // end form load

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call the function
            ClearOneRoll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //call the function
            ClearStats();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int dice1, dice2;
            //call ftn RollDice, placing returned number into integers
            dice1 = RollDice();
            dice2 = RollDice();
            //place integers into labels
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();
            // call ftn GetName sending total and returning name
            int total = dice1 + dice2;
            string rollName = GetName(total);

            //display name in label
            lblRollName.Text = rollName;

        }

        /* Name: ClearOneRoll
        *  Sent: nothing
        *  Return: nothing
        *  Clear the labels */
        private void ClearOneRoll()
        {
            lblDice1.ResetText();
            lblDice2.ResetText();
            lblRollName.ResetText();


        }


        /* Name: ClearStats
        *  Sent: nothing
        *  Return: nothing
        *  Reset nud to minimum value, chkbox unselected, 
        *  clear labels and listbox */
        private void ClearStats()
        {
            nudNumber.Value = nudNumber.Minimum;
            chkSeed.Checked = false;
            lblFail.ResetText();
            lblPass.ResetText();
            lblAverage.ResetText();
            lstMarks.Items.Clear();

        }


        /* Name: RollDice
        * Sent: nothing
        * Return: integer (1-6)
        * Simulates rolling one dice */
        private int RollDice()
        {
            
            return rand.Next(1, 7);
        }


        /* Name: GetName
        * Sent: 1 integer (total of dice1 and dice2) 
        * Return: string (name associated with total) 
        * Finds the name of dice roll based on total.
        * Use a switch statement with one return only
        * Names: 2 = Snake Eyes
        *        3 = Litle Joe
        *        5 = Fever
        *        7 = Most Common
        *        9 = Center Field
        *        11 = Yo-leven
        *        12 = Boxcars
        * Anything else = No special name*/
        private string GetName(int total)
        {
            switch (total)
            {
                case 2:
                    return "Snake Eyes";

                case 3:
                    return "Little Joe";

                case 5:
                    return "Fever";

                case 7:
                    return "Most Common";

                case 9:
                    return "Center Feild";

                case 11:
                    return "Yo-leven";

                case 12:
                    return "Boxcars";

                default:
                    return "No Special Name";

            }

        }

        private void btnSwapNumbers_Click(object sender, EventArgs e)
        {
            //call ftn DataPresent twice sending string returning boolean
            string str1 = lblDice1.Text;
            string str2 = lblDice2.Text;
            //if data present in both labels, call SwapData sending both strings
            if (DataPresent(str1) && DataPresent(str2))
            {
                SwapData(ref str1, ref str2);

                //put data back into labels
                lblDice1.Text = str1;
                lblDice2.Text = str2;
            }
            else
            {
                //if data not present in either label display error msg
                MessageBox.Show("Roll The Dice" + "Data Missing");
            }
        }
            /* Name: DataPresent
            * Sent: string
            * Return: bool (true if data, false if not) 
            * See if string is empty or not*/

            private bool DataPresent(string input)
            {
                return input != null && input.Length > 0;

            }

            /* Name: SwapData
            * Sent: 2 strings
            * Return: none 
            * Swaps the memory locations of two strings*/

            private void SwapData(ref string str1, ref string str2)
            {
                string temp = str1;
                str1 = str2;
                str2 = temp;
            }

            private void btnGenerate_Click(object sender, EventArgs e)
            {
                //declare variables and array
                int numMarks = (int)nudNumber.Value;
                int[] marks = new int[numMarks];

                //check if seed value
                if (chkSeed.Checked)
                {
                    rand = new Random(1000);
                }
                else
                {
                    rand = new Random();
                }
                lstMarks.Items.Clear();

                //fill array using random number
                int index = 0;
                while (index < marks.Length)
                {
                    marks[index] = rand.Next(40, 101);
                    lstMarks.Items.Add(marks[index]);
                    index++;
                }
                //call CalcStats sending and returning data
                int pass, fail;
                double average = CalcStats(marks, out pass, out fail);
                //display data sent back in labels - average, pass and fail
                lblAverage.Text = average.ToString("F2");
                lblPass.Text = pass.ToString();
                lblFail.Text = fail.ToString();
                // Format average always showing 2 decimal places 

            } // end Generate click

            private void radOneRoll_CheckedChanged(object sender, EventArgs e)
            {
                if (radOneRoll.Checked)
                {
                    grpOneRoll.Visible = true;
                    grpMarkStats.Visible = false;

                }
                else
                {
                    grpOneRoll.Visible = false;
                    grpMarkStats.Visible = true;
                }
            }

            /* Name: CalcStats
            * Sent: array and 2 integers
            * Return: average (double) 
            * Run a foreach loop through the array.
            * Passmark is 60%
            * Calculate average and count how many marks pass and fail
            * The pass and fail values must also get returned for display*/

            private double CalcStats(int[] marks, out int pass, out int fail)
            {
                int total = 0;
                pass = 0;
                fail = 0;

                foreach (int mark in marks)
                {
                    total += mark;

                    if (mark >= 60)
                    {
                        pass++;
                    }
                    else
                    {
                        fail++;
                    }
                }

                double average;
                if (marks.Length > 0)
                {
                    average = (double)total / marks.Length;
                }
                else
                {
                    average = 0;
                }

                return average;
            }

        private void chkSeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeed.Checked)
            {
               DialogResult dialogResult = MessageBox.Show("Are you sure you want a seed value?", "Confirm Seed Value",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    chkSeed.Checked = false;
                }
            }
        }
    }
}
