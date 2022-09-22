using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  State capital matching game
//	File Name:         Program.cs
//	Description:       This class runs the windows forms applications
//	Author:            Hiren Patel, patelhm@etsu.edu, Computing Student, East Tennessee State University
//	Created:           Saturday, April 30, 2020
//	Copyright:         Hiren Patel, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


namespace PatelHiren_Matching_State_Capital
{
    /// <summary>
    /// Runs windows forms applications 
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The Main method starts the main windows form and splash screen
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());                                 
            Application.Run(new GameForm());
        }
    }
}
