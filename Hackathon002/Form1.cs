using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hackathon002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cheap()
        {
            var text = textBox1.Text;
            var time = int.Parse(text);
            var c = 350 + 4 * time;
            var u = 400 + 3 * time;
            var t = 500 + 2 * time;
            
            //中華電信 月租費350元 每分鐘4元
            //遠傳 月租費400元 每分鐘3元
            //台灣大哥大 月租費500元 每分鐘2元
            if (c < u && c < t)
            {
                label5.Text = "中華電信";
                label6.Text = "$" + c;
            }
            else if (u < c && u < t)
            {
                label5.Text = "遠傳";
                label6.Text = "$" + u;
            }
            else if (t < u && t <c)
            {
                label5.Text = "台灣大哥大";
                label6.Text = "$" + t;
            }
            else if (t < u && t == c)
            {
                label5.Text = "台灣大哥大&中華電信";
                label6.Text = "$" + t;
            }
            else if (u < t && u == c)
            {
                label5.Text = "遠傳&中華電信";
                label6.Text = "$" + c;
            }
            else
            {
                label5.Text = "遠傳&台灣大哥大";
                label6.Text = "$" + t;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            label4.Text = textBox1.Text + "分鐘";
            cheap();
            textBox1.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    internal class ArrayList
    {
    }
}
