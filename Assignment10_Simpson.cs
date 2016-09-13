/*
Steve Simpson 21066092
2/18/2016
Intermediate C# Programming (2163-1)
Assignment 10.2
*/

using System;
using System.Windows.Forms;

namespace week10
{
    static class Assignment10_Simpson
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
