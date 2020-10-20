using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trinagle
{
    public partial class Form1 : Form
    {
        Button btn1,btn2,btn3,btn4;
        public Form1()
        {
            InitializeComponent();
            //Button btn1 = new Button();
            //{
            //    btn1.Text = "Запуск";
            //    btn1.Location = new Point(544, 96);
            //    btn1.Cursor = Cursors.Hand;
            //    btn1.FlatAppearance.BorderSize = 1;
            //    btn1.FlatStyle = FlatStyle.Flat;

            //};
            
        }
        private void button1_Click(object sender,EventArgs e)
        {

        }

       
        Form2 f2 = new Form2();

        private void button1_Click_1(object sender, EventArgs e)
        {
            f2.Show();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            f2.Show();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
