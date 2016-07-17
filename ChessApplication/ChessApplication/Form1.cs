using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        //    PictureBox zero = new PictureBox();
          //  zero.Size = new System.Drawing.Size(0, 0);
            //this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            if (pictureBox2.Size.Width == 0)
                
            {
                this.pictureBox2.Size = new System.Drawing.Size(100, 105);
                this.pictureBox3.Size = new System.Drawing.Size(100, 105);
            }
            else
            {
                this.pictureBox2.Size = new System.Drawing.Size(0, 0);
                this.pictureBox3.Size = new System.Drawing.Size(0, 0);
            }
            //e.Size = new System.Drawing.Size(0, 0);
            return;
        }

        private void pictureBox4_MouseDown(object sender, EventArgs e)
        {
            
            this.DoDragDrop(e, DragDropEffects.Copy | DragDropEffects.Move);
            //sender.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
