using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace TuringMachine
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            TuringMachine turing = new TuringMachine();
            Application.Run(turing);
        }
    }
}