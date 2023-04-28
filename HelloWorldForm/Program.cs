using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HelloWorldForm
{
    internal static class Program
    {

        public static string username;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            username = args[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
