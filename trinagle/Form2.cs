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
    public partial class Form2 : Form
    {
        Button btn , btn1, btn2,btn3;
        TreeView tree;
        Label lbl;
        CheckBox box_lbl, box_btn;
        RadioButton r1, r2;
        TextBox txt_box1,txt_box2,txt_box3;
        PictureBox picture;
        TabControl tabControl;
        TabPage page1, page2, page3;
        ListBox lbox;
        DataGridView dgv;

        public Form2()
        {
            this.Height = 500;
            this.Width = 600;
            this.Text = "Triangle Math";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("what yóu want to do?");

            tn.Nodes.Add(new TreeNode("Nupp-Button"));
            //button
            btn = new Button();
            btn.Text = "Vajuta siia";
            btn.Location = new Point(200, 100);
            btn.Height = 40;
            btn.Width = 120;
            btn.Click += Btn_Click;

            tn.Nodes.Add(new TreeNode("Silt-Label"));
            lbl = new Label();
            lbl.Text = "Tarkvara arendajad";
            lbl.Size = new Size(150, 30);
            lbl.Location = new Point(150, 200);

            //tn.Nodes.Add(new TreeNode("OutputA"));
            //txt_box1 = new TextBox();
            //txt_box1.Location = new Point(200, 250);
            //txt_box1.Text = "Vvedite a";
            //txt_box1.Height = 50;
            //txt_box1.Width = 150;
            //txt_box1.Multiline = true;
            //this.Controls.Add(txt_box1);



            tn.Nodes.Add(new TreeNode("OutputA"));
            tn.Nodes.Add(new TreeNode("OutputB"));
            tn.Nodes.Add(new TreeNode("OutputC"));
            tn.Nodes.Add(new TreeNode("OutputH"));
            tn.Nodes.Add(new TreeNode(""));
            tn.Nodes.Add(new TreeNode(""));
            tn.Nodes.Add(new TreeNode(""));
            tn.Nodes.Add(new TreeNode(""));

            tree.Nodes.Add(tn);

            this.Controls.Add(tree);

            
        }

        

        

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "OutputA")
            {

                
                txt_box1 = new TextBox();
                txt_box1.Location = new Point(300, 30);
                txt_box1.Text = "Vvedite (A)";
                txt_box1.Height = 25;
                txt_box1.Width = 60;
                txt_box1.Multiline = true;
                this.Controls.Add(txt_box1);

            }
            else if ( e.Node.Text == "OutputB")
            {
                txt_box1 = new TextBox();
                txt_box1.Location = new Point(300, 60);
                txt_box1.Text = "Vvedite (B)";
                txt_box1.Height = 25;
                txt_box1.Width = 60;
                txt_box1.Multiline = true;
                this.Controls.Add(txt_box1);
            }
            else if (e.Node.Text == "OutputC")
            {
                txt_box1 = new TextBox();
                txt_box1.Location = new Point(300, 90);
                txt_box1.Text = "Vvedite (C)";
                txt_box1.Height = 25;
                txt_box1.Width = 60;
                txt_box1.Multiline = true;
                this.Controls.Add(txt_box1);
            }
            else if (e.Node.Text == "OutputH")
            {
                txt_box1 = new TextBox();
                txt_box1.Location = new Point(300, 120);
                txt_box1.Text = "Vvedite (H)";
                txt_box1.Height = 25;
                txt_box1.Width = 60;
                txt_box1.Multiline = true;
                this.Controls.Add(txt_box1);
            }
            
           



        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (btn.BackColor == Color.Gray)
            {
                btn.BackColor = Color.Blue;
                lbl.BackColor = Color.Green;
                lbl.ForeColor = Color.White;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.Red;

            }
            else
            {
                lbl.BackColor = Color.White;
                lbl.ForeColor = Color.Green;
                btn.BackColor = Color.Gray;
            }


        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}
