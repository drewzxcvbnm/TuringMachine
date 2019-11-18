using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace TuringMachine
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;


        [STAThread]
        public static void Main(string[] args)
        {
            var cnw = GetConsoleWindow();
            ShowWindow(cnw, SW_HIDE);
            Application.EnableVisualStyles();
            TuringMachine turing = new TuringMachine();
            Application.Run(turing);
        }
    }
}