using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HelloWorldLibrary;

namespace HelloWorldForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Hello, "+Program.username;
            label2.Text = "This is using .NET Standard library: "+Formatter.FormatOutput(Program.username)+" !!!!";
        }
    }
}
