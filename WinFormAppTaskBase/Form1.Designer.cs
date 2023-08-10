using ClassLibraryTasks;
namespace WinFormAppTaskBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            t1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(366, 85);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Task Base";
            // 
            // button1
            // 
            button1.Location = new Point(319, 133);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 1;
            button1.Text = "Add New task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(319, 324);
            button2.Name = "button2";
            button2.Size = new Size(176, 29);
            button2.TabIndex = 2;
            button2.Text = "View task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(279, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 135);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 110);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 3;
            label6.Text = "label6";
            // 
            // button3
            // 
            button3.Location = new Point(87, 77);
            button3.Name = "button3";
            button3.Size = new Size(82, 30);
            button3.TabIndex = 2;
            button3.Text = "Add ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 33);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Task Name :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(t1);
            panel2.Location = new Point(118, 359);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 125);
            panel2.TabIndex = 4;
            // 
            // t1
            // 
            t1.AutoSize = true;
            t1.Location = new Point(72, 19);
            t1.Name = "t1";
            t1.Size = new Size(17, 20);
            t1.TabIndex = 5;
            t1.Text = "  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private TextBox textBox1;
        private Label label2;
        private Label label6;
        private Label t1;
        private Label label7;
        private Label label5;
        private Label label4;
    }
}