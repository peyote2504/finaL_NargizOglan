using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = (int.Parse(btn.Text) + 1).ToString();
            if(int.Parse(btn.Text)%2==0)
            {
                textBox1.Text = (int.Parse(textBox1.Text)+1).ToString();
            }
        }
    }
}
