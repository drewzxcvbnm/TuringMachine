using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class TuringMachine : Form
    {
        public TuringMachine()
        {
            InitializeComponent();
            this.tape.VerticalScroll.Enabled = false;
        }

        private Label GetLabel(string text)
        {
            Label l = new Label();
            l.BackColor = System.Drawing.Color.White;
            l.Text = text;
            l.Height = this.tape.Height-25;
            l.Width = this.tape.Height-25;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding(1);
            return l;
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.tape.Controls.Add(GetLabel("TEST"));
        }
    }
}
