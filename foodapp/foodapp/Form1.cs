using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableBoxes();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult term;

            term = MessageBox.Show("Do you want to exit the system?", "Restaurant App", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (term == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ResetBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                else
                        func(control.Controls);
            };
            func(Controls);
        }


        private void EnableBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetBoxes();
            ResetCheckBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult term1;

            term1 = MessageBox.Show("Would you like to pay now?", "Restaurant App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult term1;

            term1 = MessageBox.Show("This app was designed by Zach Sarvas for CPSC 362", "Restaurant App", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult term1;

            term1 = MessageBox.Show("Contact email: zsarvas@csu.fullerton.edu", "Restaurant App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }   
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = "";
                textBox9.Focus();
            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox13.Enabled = true;
                textBox13.Text = "";
                textBox13.Focus();
            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = "";
                textBox12.Focus();
            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();
            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();
            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = "";
                textBox11.Focus();
            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult term1;

            term1 = MessageBox.Show("You will be placed in line for a table, we will message you when a table is ready!", "Restaurant App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
