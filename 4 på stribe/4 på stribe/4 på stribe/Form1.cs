using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_på_stribe
{
    public partial class Player1 : Form
    {
        public Player1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Player1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            if (groupBox13.Visible == false)                
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox13.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox13.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                    

                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox13.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
           
            }
            
            
            
            if (groupBox24.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox24.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox24.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox24.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
            
            }

            if (groupBox27.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox27.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox27.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox27.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox39.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox39.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox39.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox39.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox57.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox57.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox57.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox57.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox66.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox66.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox66.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox66.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox81.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox81.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox81.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox81.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox90.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox90.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox90.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox90.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text= "2";
                
            }
            else
            {
                CurrentPlayer.Text= "1";
            }
        }

        private void groupBox27_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox1.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox1.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox1.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox2.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox2.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox2.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox2.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox7.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox7.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox7.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox7.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox42.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox42.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox42.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox42.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox72.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox72.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox72.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox72.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox69.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox69.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox69.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox69.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox96.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox96.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox96.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox96.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox93.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox93.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox93.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox93.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (groupBox3.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox3.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox3.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox3.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox4.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox4.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox4.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox4.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox8.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox8.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox8.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox8.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox41.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox41.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox41.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox41.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }
            if (groupBox71.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox71.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox71.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox71.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

           

            if (groupBox68.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox68.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox68.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox68.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox95.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox95.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox95.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox95.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox92.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox92.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox92.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox92.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (groupBox5.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox5.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox5.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox5.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox6.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox6.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox6.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox6.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox9.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox9.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox9.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox9.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox40.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox40.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox40.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox40.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox70.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox70.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox70.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox70.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox67.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox67.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox67.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox67.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox94.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox94.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox94.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox94.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox91.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox91.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox91.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox91.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (groupBox10.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox10.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox10.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox10.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox16.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox16.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox16.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox16.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox30.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox30.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox30.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox30.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox37.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox37.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox37.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox37.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox63.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox63.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox63.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox63.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox64.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox64.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox64.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox64.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox87.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox87.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox87.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox87.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox88.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox88.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox88.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox88.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (groupBox11.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox11.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox11.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox11.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox17.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox17.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox17.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox17.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox29.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox29.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox29.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox29.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox34.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox34.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox34.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox34.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox61.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox61.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox61.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox61.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox58.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox58.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox58.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox58.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox85.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox85.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox85.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox85.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox82.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox82.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox82.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox82.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (groupBox12.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox12.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox12.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox12.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox18.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox18.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox18.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox18.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox28.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox28.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox28.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox28.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox32.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox32.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox32.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox32.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox59.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox59.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox59.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox59.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox54.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox54.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox54.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox54.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox83.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox83.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox83.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox83.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox78.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox78.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox78.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox78.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (groupBox14.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox14.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox14.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox14.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox23.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox23.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox23.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox23.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox26.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox26.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox26.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox26.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox38.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox38.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox38.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox38.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox55.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox55.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox55.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox55.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox65.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox65.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox65.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox65.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox79.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox79.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox79.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox79.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox89.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox89.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox89.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox89.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (groupBox15.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox15.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox15.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox15.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox22.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox22.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox22.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox22.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox25.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox25.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox25.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox25.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox36.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox36.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox36.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox36.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox53.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox53.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox53.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox53.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox62.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox62.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox62.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox62.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox77.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox77.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox77.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox77.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox86.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox86.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox86.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox86.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

           

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (groupBox46.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox46.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox46.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox46.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox21.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox21.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox21.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox21.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox43.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox43.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox43.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox43.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox35.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox35.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox35.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox35.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox51.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox51.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox51.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox51.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox60.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox60.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox60.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox60.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox75.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox75.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox75.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox75.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox84.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox84.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox84.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox84.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (groupBox47.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox47.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox47.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox47.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox20.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox20.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox20.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox20.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox44.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox44.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox44.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox44.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox33.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox33.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox33.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox33.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox50.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox50.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox50.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox50.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox56.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox56.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox56.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox56.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox74.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox74.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox74.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox74.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox80.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox80.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox80.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox80.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (groupBox48.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox48.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox48.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox48.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox19.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox19.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox19.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox19.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox45.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox45.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox45.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox45.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox31.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox31.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox31.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox31.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox49.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox49.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox49.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox49.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox52.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox52.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox52.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox52.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox73.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox73.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox73.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox73.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            if (groupBox76.Visible == false)
            {
                if (CurrentPlayer.Text == "1")
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                }
                groupBox76.Visible = true;
                if (CurrentPlayer.Text == "1")
                {
                    groupBox76.BackColor = Color.Blue;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }
                if (CurrentPlayer.Text == "2")
                {
                    groupBox76.BackColor = Color.Red;
                    if (CurrentPlayer.Text == "1")
                    {
                        CurrentPlayer.Text = "2";

                    }
                    else
                    {
                        CurrentPlayer.Text = "1";
                    }
                    return;
                }

            }

            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false; 
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;

            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;
            groupBox19.Visible = false;
            groupBox20.Visible = false;

            groupBox21.Visible = false;
            groupBox22.Visible = false;
            groupBox23.Visible = false;
            groupBox24.Visible = false;
            groupBox25.Visible = false;
            groupBox26.Visible = false;
            groupBox27.Visible = false;
            groupBox28.Visible = false;
            groupBox29.Visible = false;
            groupBox30.Visible = false;

            groupBox31.Visible = false;
            groupBox32.Visible = false;
            groupBox33.Visible = false;
            groupBox34.Visible = false;
            groupBox35.Visible = false;
            groupBox36.Visible = false;
            groupBox37.Visible = false;
            groupBox38.Visible = false;
            groupBox39.Visible = false;
            groupBox40.Visible = false;

            groupBox41.Visible = false;
            groupBox42.Visible = false;
            groupBox43.Visible = false;
            groupBox44.Visible = false;
            groupBox45.Visible = false;
            groupBox46.Visible = false;
            groupBox47.Visible = false;
            groupBox48.Visible = false;
            groupBox49.Visible = false;
            groupBox50.Visible = false;

            groupBox51.Visible = false;
            groupBox52.Visible = false;
            groupBox53.Visible = false;
            groupBox54.Visible = false;
            groupBox55.Visible = false;
            groupBox56.Visible = false;
            groupBox57.Visible = false;
            groupBox58.Visible = false;
            groupBox59.Visible = false;
            groupBox60.Visible = false;

            groupBox61.Visible = false;
            groupBox62.Visible = false;
            groupBox63.Visible = false;
            groupBox64.Visible = false;
            groupBox65.Visible = false;
            groupBox66.Visible = false;
            groupBox67.Visible = false;
            groupBox68.Visible = false;
            groupBox69.Visible = false;
            groupBox70.Visible = false;

            groupBox71.Visible = false;
            groupBox72.Visible = false;
            groupBox73.Visible = false;
            groupBox74.Visible = false;
            groupBox75.Visible = false;
            groupBox76.Visible = false;
            groupBox77.Visible = false;
            groupBox78.Visible = false;
            groupBox79.Visible = false;
            groupBox80.Visible = false;

            groupBox81.Visible = false;
            groupBox82.Visible = false;
            groupBox83.Visible = false;
            groupBox84.Visible = false;
            groupBox85.Visible = false;
            groupBox86.Visible = false;
            groupBox87.Visible = false;
            groupBox88.Visible = false;
            groupBox89.Visible = false;
            groupBox90.Visible = false;

            groupBox91.Visible = false;
            groupBox92.Visible = false;
            groupBox93.Visible = false;
            groupBox94.Visible = false;
            groupBox95.Visible = false;
            groupBox96.Visible = false;
            CurrentPlayer.Text = "1";
            textBox9.BackColor = Color.Blue;


        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text == "1")
            {
                CurrentPlayer.Text = "2";

            }
            else
            {
                CurrentPlayer.Text = "1";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox114_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox77_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (CurrentPlayer.Text =="1")
            {
                textBox9.BackColor = Color.Blue;
            }



        }
    }
}
