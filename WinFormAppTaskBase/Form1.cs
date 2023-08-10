using ClassLibraryTasks;

namespace WinFormAppTaskBase
{
    public partial class Form1 : Form
    {
        List<Tasks> ListOfTasks = new List<Tasks>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            // TextBox t1 = new TextBox();
            panel2.Visible = true;
            foreach (Tasks t in ListOfTasks)
            {


                t1.Text += "Task Name is : " + t.TaskName + "Task Date is : " + t.TaskDate + Environment.NewLine;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1.Text = "";
            panel1.Visible = false;
            panel2.Visible = false;
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Tasks t = new Tasks(textBox1.Text);

                ListOfTasks.Add(t);
                label6.Text = "your task :{ " + textBox1.Text + " } is added ";
            }
            else
                label6.Text = " Enter Valid task name";

        }
    }
}