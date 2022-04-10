using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo_game
{
    public partial class Form2 : Form
    {
        public string name;
        public string path = @"table.txt";
        public Form2()
        {
            InitializeComponent();

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.name = this.name;
            form1.path = this.path;
            form1.Show();
            
        }

        private void rating_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            name = textBox_name.Text;
        }
    }
}
