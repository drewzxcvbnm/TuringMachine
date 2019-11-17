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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.run = new System.Windows.Forms.Button();
            this.step = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.copy_tape = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tape, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.79476F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.20524F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 432);
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
            this.panel1.Location = new System.Drawing.Point(2, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 284);
            this.panel1.TabIndex = 2;
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(132, 164);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(108, 66);
            this.set.TabIndex = 11;
            this.set.Text = "Set Machine";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // rules
            // 
            this.rules.Location = new System.Drawing.Point(282, 74);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(474, 196);
            this.rules.TabIndex = 10;
            this.rules.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(246, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Use following format: <old_state> <old_symbol> <new_symbol> <move> <new_state>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(282, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rules:";
            // 
            // head_box
            // 
            this.head_box.Location = new System.Drawing.Point(132, 122);
            this.head_box.Name = "head_box";
            this.head_box.Size = new System.Drawing.Size(108, 23);
            this.head_box.TabIndex = 7;
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(132, 93);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(108, 23);
            this.input_box.TabIndex = 6;
            // 
            // end_state_box
            // 
            this.end_state_box.Location = new System.Drawing.Point(132, 63);
            this.end_state_box.Name = "end_state_box";
            this.end_state_box.Size = new System.Drawing.Size(108, 23);
            this.end_state_box.TabIndex = 5;
            // 
            // start_state_box
            // 
            this.start_state_box.Location = new System.Drawing.Point(132, 33);
            this.start_state_box.Name = "start_state_box";
            this.start_state_box.Size = new System.Drawing.Size(108, 23);
            this.start_state_box.TabIndex = 4;
            // 
            // head
            // 
            this.head.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.head.Location = new System.Drawing.Point(10, 115);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(115, 29);
            this.head.TabIndex = 3;
            this.head.Text = "Head position:";
            this.head.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.input.Location = new System.Drawing.Point(27, 87);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(99, 29);
            this.input.TabIndex = 2;
            this.input.Text = "Input:";
            this.input.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // end_state
            // 
            this.end_state.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.end_state.Location = new System.Drawing.Point(27, 57);
            this.end_state.Name = "end_state";
            this.end_state.Size = new System.Drawing.Size(99, 29);
            this.end_state.TabIndex = 1;
            this.end_state.Text = "End state:";
            this.end_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // start_state
            // 
            this.start_state.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.start_state.Location = new System.Drawing.Point(27, 28);
            this.start_state.Name = "start_state";
            this.start_state.Size = new System.Drawing.Size(99, 29);
            this.start_state.TabIndex = 0;
            this.start_state.Text = "Start state:";
            this.start_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tape
            // 
            this.tape.AutoScroll = true;
            this.tape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tape.Location = new System.Drawing.Point(1, 63);
            this.tape.Margin = new System.Windows.Forms.Padding(1);
            this.tape.Name = "tape";
            this.tape.Size = new System.Drawing.Size(780, 80);
            this.tape.TabIndex = 0;
            this.tape.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.run);
            this.flowLayoutPanel1.Controls.Add(this.step);
            this.flowLayoutPanel1.Controls.Add(this.status);
            this.flowLayoutPanel1.Controls.Add(this.info);
            this.flowLayoutPanel1.Controls.Add(this.copy_tape);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 56);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // run
            // 
            this.run.Enabled = false;
            this.run.Location = new System.Drawing.Point(3, 3);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(86, 53);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // step
            // 
            this.step.Enabled = false;
            this.step.Location = new System.Drawing.Point(95, 3);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(86, 53);
            this.step.TabIndex = 1;
            this.step.Text = "Step";
            this.step.UseVisualStyleBackColor = true;
            this.step.Click += new System.EventHandler(this.step_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(187, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(118, 57);
            this.status.TabIndex = 3;
            this.status.Text = "Current state:";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(311, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(379, 57);
            this.info.TabIndex = 2;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copy_tape
            // 
            this.copy_tape.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.copy_tape.Enabled = false;
            this.copy_tape.Location = new System.Drawing.Point(696, 3);
            this.copy_tape.Name = "copy_tape";
            this.copy_tape.Size = new System.Drawing.Size(66, 53);
            this.copy_tape.TabIndex = 4;
            this.copy_tape.Text = "Copy tape";
            this.copy_tape.UseVisualStyleBackColor = true;
            this.copy_tape.Click += new System.EventHandler(this.copy_tape_Click);
            // 
            // TuringMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TuringMachine";
            this.Text = "TuringMachineSimulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel tape;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
    }
}