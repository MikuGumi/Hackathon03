using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hackathon004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void TopList()
        {
            var cabs = int.Parse(textBox1.Text) * 30;
            var dbs = int.Parse(textBox2.Text) * 15;
            var kelps = int.Parse(textBox3.Text) * 15;
            var meats = int.Parse(textBox4.Text) * 40;

            listBox1.Items.Add("高麗菜：" + cabs + "元");
            listBox1.Items.Add("海帶：" + dbs + "元");
            listBox1.Items.Add("豆干：" + kelps + "元");
            listBox1.Items.Add("肉片：" + meats + "元");

            var total = cabs + dbs + kelps + meats;

            var thousands = total / 1000;
            var a = total % 1000;

            var hundred = a / 500;
            var b = a % 500;

            var fifty = b / 50;
            var c = b % 50;

            var ten = c / 10;
            var d = c % 10;

            var five = d / 5;
            var e = d % 5;

            var one = e;

            listBox2.Items.Add("總共：" + total + "元");
            listBox2.Items.Add("千元：" + thousands + "張");
            listBox2.Items.Add("五百：" + hundred + "張");
            listBox2.Items.Add("五十：" + fifty + "張");
            listBox2.Items.Add("十元：" + ten + "張");
            listBox2.Items.Add("五元：" + five + "張");
            listBox2.Items.Add("一元：" + one + "張");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopList();
        }
    }
}
