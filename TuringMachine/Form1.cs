using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class TuringMachine : Form
    {
        private string inp = @"goto-operator  1  1  R  goto-operator
goto-operator  x  x  R  goto-operator
goto-operator  *  *  R  check-zero-power
check-zero-power  _  =  R  zero-power
check-zero-power  1  1  R  add-equals
add-equals  1  1  R  add-equals
add-equals  _  =  L  goto-left-corner
goto-left-corner  1  1  L  goto-left-corner
goto-left-corner  x  x  L  goto-left-corner
goto-left-corner  =  =  L  goto-left-corner
goto-left-corner  *  *  L  goto-left-corner
goto-left-corner  _  _  R  carry-first-num
zero-power  =  =  R  zero-power
zero-power  _  1  R  done
carry-first-num  x  x  R  carry-first-num
carry-first-num  1  x  R  add-one-as-root
carry-first-num  *  *  R  set-x-and-left
add-one-as-root  1  1  R  add-one-as-root
add-one-as-root  x  x  R  add-one-as-root
add-one-as-root  *  *  R  add-one-as-root
add-one-as-root  =  =  R  add-one-as-root
add-one-as-root  _  x  L  goto-left-corner
set-x-and-left  x  x  R  set-x-and-left
set-x-and-left  1  x  L  add-power
add-power  x  x  R  add-power
add-power  *  *  R  add-power
add-power  1  x  L  to-operator
add-power  =  =  R  root-to-number
to-operator  x  x  L  to-operator
to-operator  1  1  L  to-operator
to-operator  *  *  L  left-motion-x-to-ones
left-motion-x-to-ones  1  1  L  left-motion-x-to-ones
left-motion-x-to-ones  *  *  L  left-motion-x-to-ones
left-motion-x-to-ones  =  =  L  left-motion-x-to-ones
left-motion-x-to-ones  x  1  L  left-motion-x-to-ones
left-motion-x-to-ones  _  _  R  ignore-first-digit
ignore-first-digit  1  x  R  continue-multiplication
ignore-first-digit  *  *  R  zero-number
zero-number  x  x  R  zero-number
zero-number  =  =  R  zero-number
zero-number  1  x  R  zero-number
zero-number  _  _  R  done
continue-multiplication  *  *  R  increase-root
continue-multiplication  x  x  R  continue-multiplication
continue-multiplication  1  x  R  go-to-root
go-to-root  1  1  R  go-to-root
go-to-root  x  x  R  go-to-root
go-to-root  *  *  R  go-to-root
go-to-root  =  =  R  duplicate-root
duplicate-root  0  0  R  duplicate-root
duplicate-root  x  0  R  add-one-to-be-root
duplicate-root  2  2  R  back-to-first-operand-fixing-root
add-one-to-be-root  1  1  R  add-one-to-be-root
add-one-to-be-root  x  x  R  add-one-to-be-root
add-one-to-be-root  *  *  R  add-one-to-be-root
add-one-to-be-root  =  =  R  add-one-to-be-root
add-one-to-be-root  0  0  R  add-one-to-be-root
add-one-to-be-root  2  2  R  add-one-to-be-root
add-one-to-be-root  _  2  L  to-root-beginning
to-root-beginning  1  1  L  to-root-beginning
to-root-beginning  x  x  L  to-root-beginning
to-root-beginning  *  *  L  to-root-beginning
to-root-beginning  0  0  L  to-root-beginning
to-root-beginning  2  2  L  to-root-beginning
to-root-beginning  =  =  R  duplicate-root
back-to-first-operand-fixing-root  1  1  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  x  x  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  *  *  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  =  =  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  2  2  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  0  x  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  _  _  R  continue-multiplication
increase-root  1  1  R  increase-root
increase-root  x  x  R  increase-root
increase-root  *  *  R  increase-root
increase-root  =  =  R  increase-root
increase-root  0  0  R  increase-root
increase-root  2  x  R  increase-root
increase-root  _  _  L  to-middle
to-middle  1  1  L  to-middle
to-middle  x  x  L  to-middle
to-middle  =  =  L  to-middle
to-middle  0  0  L  to-middle
to-middle  *  *  R  add-power
root-to-number  x  1  R  root-to-number
root-to-number  _  _  R  done";

        private Machine.TuringMachine _machine;
        private List<Label> _tapeControls = new List<Label>();
        private int _head;
        private bool _shouldStop = false;
        private Thread backgroundThread;

        public TuringMachine()
        {
            InitializeComponent();
            this.tape.VerticalScroll.Enabled = false;
            for (int i = 0; i < 100; i++)
                this.tape.Controls.Add(GetLabel("_"));
            this.rules.Text = inp;
            this.start_state_box.Text = "goto-operator";
            this.end_state_box.Text = "done";
            this.input_box.Text = "11*111";
            this.head_box.Text = "0";
        }

        private Label GetLabel(string text)
        {
            Label l = new Label();
            l.BackColor = Color.White;
            l.Text = text;
            l.Height = this.tape.Height - 25;
            l.Width = this.tape.Height - 25;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding(1);
            return l;
        }

        private void set_Click(object sender, EventArgs e)
        {
            backgroundThread?.Abort();
            _machine = new Machine.TuringMachine(
                Convert.ToInt32(this.head_box.Text),
                this.start_state_box.Text,
                this.end_state_box.Text,
                this.input_box.Text,
                this.rules.Text
            );
            _head = _machine.Head;
            EmptyTape();
            AlignTape();
            this.run.Enabled = true;
            this.step.Enabled = true;
            this.copy_tape.Enabled = true;
            this.rate.Enabled = true;
            this.stop.Enabled = false;
            rate_TextChanged(null, null);
            _shouldStop = true;
        }

        private void EmptyTape()
        {
            for (int i = 0; i < this.tape.Controls.Count; i++)
            {
                tape.Controls[i].Text = @"_";
                tape.Controls[i].BackColor = Color.White;
            }
            this.status.Text = string.Format("Current state:\n{0}", _machine.CurrentState);
            info.Text = "";
        }

        private void AlignTape()
        {
            _tapeControls = _machine.Tape.Select(CharToLabel).ToList();
            for (int i = 0; i < _tapeControls.Count; i++)
            {
                if (i >= this.tape.Controls.Count)
                {
                    this.tape.Controls.Add(GetLabel("_"));
                }

                this.tape.Controls[i].Text = _tapeControls[i].Text;
            }

            this.tape.Controls[_head].BackColor = Color.White;
            _head = _machine.Head;
            this.tape.Controls[_head].BackColor = Color.Aquamarine;
        }

        private Label CharToLabel(char c)
        {
            return GetLabel(c.ToString());
        }

        private void step_Click(object sender, EventArgs e)
        {
            _machine.ExecuteStep();
            AlignTape();
            this.status.Text = string.Format("Current state:\n{0}", _machine.CurrentState);
            if (!_machine.CanContinue)
            {
                this.info.Text = @"Final state is reached";
                this.run.Enabled = false;
                this.step.Enabled = false;
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            _machine.Run();
            AlignTape();
            this.status.Text = string.Format("Current state:\n{0}", _machine.CurrentState);
            this.info.Text = @"Final state is reached";
            this.run.Enabled = false;
            this.step.Enabled = false;
        }

        private void copy_tape_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join("", _machine.Tape));
        }

        private void rate_TextChanged(object sender, EventArgs e)
        {
            int miliSeconds;
            if (int.TryParse(this.rate.Text,out miliSeconds)) 
            {
                this.start.Enabled = true;
            }
            else
            {
                this.start.Enabled = false;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            int wait = int.Parse(this.rate.Text);
            this.stop.Enabled = true;
            this.start.Enabled = false;
            _shouldStop = false;
            backgroundThread = new Thread(
                new ThreadStart(
                    () =>
                    {
                        while (_machine.CanContinue && !_shouldStop)
                        {
                            Thread.Sleep(wait);
                            _machine.ExecuteStep();
                            this.Invoke((MethodInvoker)(() => {
                                AlignTape();
                                this.status.Text = string.Format("Current state:\n{0}", _machine.CurrentState);
                            }));
                        }
                        if (!_machine.CanContinue)
                        {
                            this.Invoke((MethodInvoker)(() =>
                            {
                                this.info.Text = @"Final state is reached";
                                this.run.Enabled = false;
                                this.step.Enabled = false;
                            }));
                        }
                    }
                    )
                );
            backgroundThread.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            _shouldStop = true;
            this.start.Enabled = true;
            this.stop.Enabled = false;
        }
    }
}