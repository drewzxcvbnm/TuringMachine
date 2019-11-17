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
            this.tape = new System.Windows.Forms.FlowLayoutPanel();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tape, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.add, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.79476F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.20524F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1228, 690);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tape
            // 
            this.tape.AutoScroll = true;
            this.tape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tape.Location = new System.Drawing.Point(1, 99);
            this.tape.Margin = new System.Windows.Forms.Padding(1);
            this.tape.Name = "tape";
            this.tape.Size = new System.Drawing.Size(1226, 129);
            this.tape.TabIndex = 0;
            this.tape.WrapContents = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 92);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 455);
            this.panel1.TabIndex = 2;
            // 
            // TuringMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TuringMachine";
            this.Text = "TuringMachine";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel tape;
        private Button add;
        private Panel panel1;
    }
}