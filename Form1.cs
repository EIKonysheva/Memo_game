using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Memo_game
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public string path;
        public string name;
        int points;
        DateTime date1 = new DateTime(0, 0);
        PictureBox firstClicked = null;
        PictureBox secondClicked = null;     
        public Form1()
        {
            InitializeComponent();
            label_points.Text = points.ToString();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"pic1.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox1;
            }
            else
            {
                secondClicked = pictureBox1;
                if (firstClicked==pictureBox15)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else 
                { 
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"pic3.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox2;
            }
            else
            {
                secondClicked = pictureBox2;
                if (firstClicked == pictureBox23)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"pic4.png");           
            if (firstClicked == null)
            {
                firstClicked = pictureBox3;
            }
            else
            {
                secondClicked = pictureBox3;
                if (firstClicked == pictureBox34)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"pic7.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox4;
            }
            else
            {
                secondClicked = pictureBox4;
                if (firstClicked == pictureBox10)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"pic10.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox5;
            }
            else
            {
                secondClicked = pictureBox5;
                if (firstClicked == pictureBox16)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"pic18.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox6;
            }
            else
            {
                secondClicked = pictureBox6;
                if (firstClicked == pictureBox7)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"pic18.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox7;
            }
            else
            {
                secondClicked = pictureBox7;
                if (firstClicked == pictureBox6)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(@"pic2.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox8;
            }
            else
            {
                secondClicked = pictureBox8;
                if (firstClicked == pictureBox27)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(@"pic8.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox9;
            }
            else
            {
                secondClicked = pictureBox9;
                if (firstClicked == pictureBox28)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile(@"pic7.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox10;
            }
            else
            {
                secondClicked = pictureBox10;
                if (firstClicked == pictureBox4)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"pic17.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox11;
            }
            else
            {
                secondClicked = pictureBox11;
                if (firstClicked == pictureBox24)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"pic16.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox12;
            }
            else
            {
                secondClicked = pictureBox12;
                if (firstClicked == pictureBox29)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(@"pic9.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox13;
            }
            else
            {
                secondClicked = pictureBox13;
                if (firstClicked == pictureBox17)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(@"pic15.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox14;
            }
            else
            {
                secondClicked = pictureBox14;
                if (firstClicked == pictureBox30)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Image.FromFile(@"pic1.png");           
            if (firstClicked == null)
            {
                firstClicked = pictureBox15;
            }
            
            else
            {
                secondClicked = pictureBox15;
                if (firstClicked==pictureBox1)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile(@"pic10.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox16;
            }
            else
            {
                secondClicked = pictureBox16;
                if (firstClicked == pictureBox5)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Image.FromFile(@"pic9.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox17;
            }
            else
            {
                secondClicked = pictureBox17;
                if (firstClicked == pictureBox13)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile(@"pic6.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox18;
            }
            else
            {
                secondClicked = pictureBox18;
                if (firstClicked == pictureBox25)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile(@"pic14.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox19;
            }
            else
            {
                secondClicked = pictureBox19;
                if (firstClicked == pictureBox21)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile(@"pic5.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox20;
            }
            else
            {
                secondClicked = pictureBox20;
                if (firstClicked == pictureBox36)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile(@"pic14.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox21;
            }
            else
            {
                secondClicked = pictureBox21;
                if (firstClicked == pictureBox19)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.Image = Image.FromFile(@"pic12.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox22;
            }
            else
            {
                secondClicked = pictureBox22;
                if (firstClicked == pictureBox31)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Image = Image.FromFile(@"pic3.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox23;
            }
            else
            {
                secondClicked = pictureBox23;
                if (firstClicked == pictureBox2)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Image = Image.FromFile(@"pic17.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox24;
            }
            else
            {
                secondClicked = pictureBox24;
                if (firstClicked == pictureBox11)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Image = Image.FromFile(@"pic6.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox25;
            }
            else
            {
                secondClicked = pictureBox25;
                if (firstClicked == pictureBox18)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Image = Image.FromFile(@"pic11.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox26;
            }
            else
            {
                secondClicked = pictureBox26;
                if (firstClicked == pictureBox35)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.Image = Image.FromFile(@"pic2.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox27;
            }
            else
            {
                secondClicked = pictureBox27;
                if (firstClicked == pictureBox8)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.Image = Image.FromFile(@"pic8.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox28;
            }
            else
            {
                secondClicked = pictureBox28;
                if (firstClicked == pictureBox9)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.Image = Image.FromFile(@"pic16.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox29;
            }
            else
            {
                secondClicked = pictureBox29;
                if (firstClicked == pictureBox12)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.Image = Image.FromFile(@"pic15.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox30;
            }
            else
            {
                secondClicked = pictureBox30;
                if (firstClicked == pictureBox14)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.Image = Image.FromFile(@"pic12.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox31;
            }
            else
            {
                secondClicked = pictureBox31;
                if (firstClicked == pictureBox22)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.Image = Image.FromFile(@"pic13.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox32;
            }
            else
            {
                secondClicked = pictureBox32;
                if (firstClicked == pictureBox33)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Image = Image.FromFile(@"pic13.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox33;
            }
            else
            {
                secondClicked = pictureBox33;
                if (firstClicked == pictureBox32)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.Image = Image.FromFile(@"pic4.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox34;
            }
            else
            {
                secondClicked = pictureBox34;
                if (firstClicked == pictureBox3)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.Image = Image.FromFile(@"pic11.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox35;
            }
            else
            {
                secondClicked = pictureBox35;
                if (firstClicked == pictureBox26)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }
        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.Image = Image.FromFile(@"pic5.png");
            if (firstClicked == null)
            {
                firstClicked = pictureBox36;
            }
            else
            {
                secondClicked = pictureBox36;
                if (firstClicked == pictureBox20)
                {
                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    points++;
                    label_points.Text = points.ToString();
                }
                else
                {
                    firstClicked.Image = Image.FromFile(@"memofon1.jpg");
                    secondClicked.Image = Image.FromFile(@"memofon1.jpg");
                    firstClicked = null;
                    secondClicked = null;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddMilliseconds(1);
            label_time.Text = date1.ToString("ss:ff");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Привет, " + name + "!";
            if (timer1.Enabled == true)
                    timer1.Enabled = false;
                else
                    timer1.Enabled = true;           
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(name + " " + label_time.Text + " " + label_points.Text);
            writer.Close();
            Close();
        }
    }
}   

