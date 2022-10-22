using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4VP
{
    public partial class Animals : Form
    {
        public Animals()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ans=0;
            if (radioButton2.Checked == true)
            {
                ans++;
            }
            if (radioButton8.Checked == true)
            {
                ans++;
            }
            if (radioButton10.Checked == true)
            {
                ans++;
            }
            if (radioButton13.Checked == true)
            {
                ans++;
            }
            if (radioButton20.Checked == true)
            {
                ans++;
            }

            //panel6.Visible = true;
            //button1.Text = ans.ToString()+" / 5";

           
            if (ans == 0 || ans == 1|| ans == 2)
            {
                MessageBox.Show("Your score is "+ ans + " / 5" + "\nYou should learn again dear!!!", "Result");
            }

            if (ans == 3)
            {
                MessageBox.Show("Your score is " + ans + " / 5" + "\nNice effort dear!!!", "Result");
            }
            if (ans == 4)
            {
                MessageBox.Show("Your score is " + ans + " / 5" + "\nWelldone dear!!", "Result");
            }
            if (ans == 5)
            {
                MessageBox.Show("Your score is " + ans + " / 5" + "\nSuperb dear!!", "Result");
            }

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
