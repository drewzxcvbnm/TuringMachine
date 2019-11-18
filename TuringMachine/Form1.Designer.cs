using System.Windows.Forms;

namespace TuringMachine
{
    partial class TuringMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.set = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.head_box = new System.Windows.Forms.TextBox();
            this.input_box = new System.Windows.Forms.TextBox();
            this.end_state_box = new System.Windows.Forms.TextBox();
            this.start_state_box = new System.Windows.Forms.TextBox();
            this.head = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Label();
            this.end_state = new System.Windows.Forms.Label();
            this.start_state = new System.Windows.Forms.Label();
            this.tape = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.run = new System.Windows.Forms.Button();
            this.step = new System.Windows.Forms.Button();
            this.copy_tape = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tape, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1207, 690);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.set);
            this.panel1.Controls.Add(this.rules);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.head_box);
            this.panel1.Controls.Add(this.input_box);
            this.panel1.Controls.Add(this.end_state_box);
            this.panel1.Controls.Add(this.start_state_box);
            this.panel1.Controls.Add(this.head);
            this.panel1.Controls.Add(this.input);
            this.panel1.Controls.Add(this.end_state);
            this.panel1.Controls.Add(this.start_state);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 444);
            this.panel1.TabIndex = 2;
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(207, 262);
            this.set.Margin = new System.Windows.Forms.Padding(5);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(170, 106);
            this.set.TabIndex = 11;
            this.set.Text = "Set Machine";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // rules
            // 
            this.rules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rules.Location = new System.Drawing.Point(443, 118);
            this.rules.Margin = new System.Windows.Forms.Padding(5);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(743, 311);
            this.rules.TabIndex = 10;
            this.rules.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(387, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(805, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Use following format: <old_state> <old_symbol> <new_symbol> <move> <new_state>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(443, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rules:";
            // 
            // head_box
            // 
            this.head_box.Location = new System.Drawing.Point(207, 195);
            this.head_box.Margin = new System.Windows.Forms.Padding(5);
            this.head_box.Name = "head_box";
            this.head_box.Size = new System.Drawing.Size(167, 29);
            this.head_box.TabIndex = 7;
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(207, 149);
            this.input_box.Margin = new System.Windows.Forms.Padding(5);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(167, 29);
            this.input_box.TabIndex = 6;
            // 
            // end_state_box
            // 
            this.end_state_box.Location = new System.Drawing.Point(207, 101);
            this.end_state_box.Margin = new System.Windows.Forms.Padding(5);
            this.end_state_box.Name = "end_state_box";
            this.end_state_box.Size = new System.Drawing.Size(167, 29);
            this.end_state_box.TabIndex = 5;
            // 
            // start_state_box
            // 
            this.start_state_box.Location = new System.Drawing.Point(207, 53);
            this.start_state_box.Margin = new System.Windows.Forms.Padding(5);
            this.start_state_box.Name = "start_state_box";
            this.start_state_box.Size = new System.Drawing.Size(167, 29);
            this.start_state_box.TabIndex = 4;
            // 
            // head
            // 
            this.head.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.head.Location = new System.Drawing.Point(3, 192);
            this.head.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(195, 37);
            this.head.TabIndex = 3;
            this.head.Text = "Head position:";
            this.head.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.input.Location = new System.Drawing.Point(42, 149);
            this.input.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(156, 37);
            this.input.TabIndex = 2;
            this.input.Text = "Input:";
            this.input.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // end_state
            // 
            this.end_state.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.end_state.Location = new System.Drawing.Point(42, 101);
            this.end_state.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.end_state.Name = "end_state";
            this.end_state.Size = new System.Drawing.Size(156, 37);
            this.end_state.TabIndex = 1;
            this.end_state.Text = "End state:";
            this.end_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // start_state
            // 
            this.start_state.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.start_state.Location = new System.Drawing.Point(42, 53);
            this.start_state.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.start_state.Name = "start_state";
            this.start_state.Size = new System.Drawing.Size(156, 38);
            this.start_state.TabIndex = 0;
            this.start_state.Text = "Start state:";
            this.start_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tape
            // 
            this.tape.AutoScroll = true;
            this.tape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tape.Location = new System.Drawing.Point(2, 122);
            this.tape.Margin = new System.Windows.Forms.Padding(2);
            this.tape.Name = "tape";
            this.tape.Size = new System.Drawing.Size(1203, 116);
            this.tape.TabIndex = 0;
            this.tape.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.stop);
            this.panel2.Controls.Add(this.start);
            this.panel2.Controls.Add(this.rate);
            this.panel2.Controls.Add(this.run);
            this.panel2.Controls.Add(this.step);
            this.panel2.Controls.Add(this.copy_tape);
            this.panel2.Controls.Add(this.info);
            this.panel2.Controls.Add(this.status);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1201, 114);
            this.panel2.TabIndex = 3;
            // 
            // run
            // 
            this.run.Enabled = false;
            this.run.Location = new System.Drawing.Point(11, 5);
            this.run.Margin = new System.Windows.Forms.Padding(5);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(135, 106);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // step
            // 
            this.step.Enabled = false;
            this.step.Location = new System.Drawing.Point(156, 5);
            this.step.Margin = new System.Windows.Forms.Padding(5);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(135, 106);
            this.step.TabIndex = 1;
            this.step.Text = "Step";
            this.step.UseVisualStyleBackColor = true;
            this.step.Click += new System.EventHandler(this.step_Click);
            // 
            // copy_tape
            // 
            this.copy_tape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copy_tape.Enabled = false;
            this.copy_tape.Location = new System.Drawing.Point(1086, 6);
            this.copy_tape.Margin = new System.Windows.Forms.Padding(5);
            this.copy_tape.Name = "copy_tape";
            this.copy_tape.Size = new System.Drawing.Size(104, 85);
            this.copy_tape.TabIndex = 4;
            this.copy_tape.Text = "Copy tape";
            this.copy_tape.UseVisualStyleBackColor = true;
            this.copy_tape.Click += new System.EventHandler(this.copy_tape_Click);
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.info.Location = new System.Drawing.Point(697, 6);
            this.info.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(355, 91);
            this.info.TabIndex = 2;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(502, 11);
            this.status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(185, 91);
            this.status.TabIndex = 3;
            this.status.Text = "Current state:";
            // 
            // rate
            // 
            this.rate.Enabled = false;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(325, 3);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(125, 23);
            this.rate.TabIndex = 5;
            this.rate.TextChanged += new System.EventHandler(this.rate_TextChanged);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(325, 38);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(125, 35);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(325, 76);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(125, 35);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // TuringMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TuringMachine";
            this.Text = "TuringMachineSimulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel tape;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button step;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label start_state;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label end_state;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.RichTextBox rules;
        private System.Windows.Forms.TextBox head_box;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.TextBox end_state_box;
        private System.Windows.Forms.TextBox start_state_box;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button copy_tape;
        private Panel panel2;
        private Button stop;
        private Button start;
        private TextBox rate;
    }
}