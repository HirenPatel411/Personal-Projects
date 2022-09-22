using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  State capital matching game
//	File Name:         GameForm.cs
//	Description:       This class runs the main form and has all the methods for the button clicks and the start of the game
//	Course:            CSCI 2210-001 - Data Structures	
//	Author:            Hiren Patel, patelhm@etsu.edu, Computing Student, East Tennessee State University
//	Created:           Saturday, April 30, 2020
//	Copyright:         Hiren Patel, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PatelHiren_Matching_State_Capital
{
    /// <summary>
    /// Runs the main form and the games controls
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class GameForm : Form
    {
        #region Properties
        SortedDictionary<string, string> sortDict = new SortedDictionary<string, string>();   //Holds the key and value of the states and its matching capital
        StreamReader strmRdr= null;                                                           //Streamreader for the games text file
        Random rand;                                                                          //Variable random
        string[] States = null;                                                               //Array of States
        string[] Capitals = null;                                                             //Array of Capitals
        string[] fileOfStates = null;                                                         //Array of the pictures of the states
        string currentState = null;                                                           //The current state during the game
        #endregion

        #region Constructor        
        /// <summary>
        /// This method is a non-parameterized constructor that reads the files
        /// <see cref="GameForm"/> class.
        /// </summary>
        public GameForm()
        {
            rand = new Random();

            try
            {
                strmRdr = new StreamReader(@"..\..\State Data\capitals.txt");
                fileOfStates = new string[50];
                for (int i = 0; i < 50; i++)
                {
                    string temp = "";
                    string[] tempArray = new string[2];
                    temp = strmRdr.ReadLine().Replace(", ", ",");
                    tempArray = temp.Split(',');
                    sortDict.Add(tempArray[1], tempArray[0]);
                    string str = tempArray[1].Replace(" ", ""); //This removes the space between the state name due to the JPEG names
                    fileOfStates[i] = tempArray[1] + "-" + $"..\\..\\State Pictures\\{str}State.jpg";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file was not read.", "Matching State Capitals", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (strmRdr != null)
                {
                    strmRdr.Close();
                }
            
            }

            try
            {
                var files = from file in fileOfStates
                        orderby file
                        select file;
                fileOfStates = files.ToArray();
                files = null;

                Capitals = sortDict.Values.ToArray();
                files = from file in Capitals
                    orderby file
                    select file;
                Capitals = files.ToArray();
                files = null;

                InitializeComponent();
                
                attemptBox.Text = ((int)0).ToString();    //0 in attempt box
                correctBox.Text = ((int)0).ToString();    //0 in correct box

                capitalListBox.Items.AddRange(Capitals);

                States = sortDict.Keys.ToArray();
                files = from file in States
                    orderby file
                    select file;
                States = files.ToArray();
                files = null;
                Begin();
            }
            catch
            {
                MessageBox.Show("The game could not start correctly", "Matching State Capitals",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Method handles the SelectedIndexChanged event and lets the user choose the capital of the state.
        /// If the users answer is correct or incorrect it displays a message.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void capitalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCapital = capitalListBox.SelectedItem.ToString();

            if (sortDict[currentState] == selectedCapital)
            {
                questionTimer.Stop();
                capitalListBox.Enabled = false;
                MessageBox.Show($"Congratulations! Your answer was correct.\nPlease click Next Question to continue..", "Matching State Capitals",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                nextQuestion.Enabled = true;
                correctBox.Text = (Int32.Parse(correctBox.Text) + 1).ToString();
                attemptBox.Text = (Int32.Parse(attemptBox.Text) + 1).ToString();
            }
            else
            {
                questionTimer.Stop();
                capitalListBox.Enabled = false;
                MessageBox.Show($"Sorry your answer was incorrect.\nYou should have chose {sortDict[currentState]}\nPlease click Next Question to continue..",
                    "Matching State Capitals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nextQuestion.Enabled = true;
                attemptBox.Text = (Int32.Parse(attemptBox.Text) + 1).ToString();

            }
        }

        /// <summary>
        /// Begins a round of the game and starts the timer at 15 seconds.
        /// </summary>
        private void Begin()
        {
            nextQuestion.Enabled = false;
            capitalListBox.Enabled = true;

            int num = rand.Next(50);
            currentState = States[num];

            for (int i = 0; i < fileOfStates.Length; i++)
            {
                if (fileOfStates[i].Contains(currentState))
                {
                    int fileIndex = fileOfStates[i].IndexOf('.');
                    string location = fileOfStates[i].Substring(fileIndex);
                    statePictureBox.ImageLocation = location;
                    break; //breaks out after located
                }
            }

            stateNameBox.Text = currentState;
            timeBox.Text = "15";
            questionTimer.Start();
        }

        /// <summary>
        /// Method handles the Click event of the next question. 
        /// Once the next button is clicked it runs the Begin() method again
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void nextQuestion_Click(object sender, EventArgs e)
        {
            Begin(); //begins another round
        }

        /// <summary>
        /// Method handles the Click event of the end button control
        /// when the end button is clicked this method shows a message box of your score else
        /// shows a goodbye message.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void endButton_Click(object sender, EventArgs e)
        {
            if (Double.Parse(attemptBox.Text) != 0)
            {
                Double points = (Double)(Double.Parse(correctBox.Text) / Double.Parse(attemptBox.Text)) * 100;
                Double roundPoints = Math.Round(points, 2);

                MessageBox.Show($"I hope you enjoyed playing. " +
                    $"\nYou scored a total of {roundPoints}% out of "
                    + $"{Int32.Parse(attemptBox.Text)} attempt(s).",
                    "Matching State Capitals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Come and play later!", "Matching State Capitals",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                questionTimer.Stop();
            }

            Close();
        }

        /// <summary>
        /// Method handles the Tick event of the questionTimer control.
        /// This methods decrements the time every second and after time is up a message box shows.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void questionTimer_Tick(object sender, EventArgs e)
        {
            if (Int32.Parse(timeBox.Text) >= 1)
            {
                timeBox.Text = (Int32.Parse(timeBox.Text) - 1).ToString();
            }
            else
            {
                capitalListBox.Enabled = false;
                nextQuestion.Enabled = true;

                questionTimer.Stop();
                MessageBox.Show($"Time is up!\nYou should have chose {sortDict[currentState]}\nPlease click Next Question to continue..", "Matching State Capitals",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                attemptBox.Text = (Int32.Parse(attemptBox.Text) + 1).ToString();
            }
        }
        #endregion
    }
}
