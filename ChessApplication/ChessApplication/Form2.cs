using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ChessApplication
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        //    for (int i = 0; i < 8; i++)
        //    {
        //        //How to access the images
        //        //global::ChessApplication.Properties.Resources.White;

        //        List<PictureBox> sublist = new List<PictureBox>();
        //        for (int j = 0; i < 8; j++)
        //        {
        //            sublist.Add(new PictureBox());
        //            sublist.ElementAt(j).Size = new System.Drawing.Size(115, 115);
        //            sublist.ElementAt(j).DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
        //            //sublist.ElementAt(j).DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DrageEnter);
        //            //sublist.ElementAt(j).MouseDown += new System.Windows.Forms.DragEventHandler(this.pictureBox_MouseDown);
        //            sublist.ElementAt(j).TabStop = false;
        //            sublist.ElementAt(j).TabIndex = i + j;
        //            sublist.ElementAt(j).Name = (((char)i).ToString()).ToUpper() + j;
        //            //Making every other tile White then Black
        //            if ((i + j) % 2 == 0)
        //            {
        //                sublist.ElementAt(j).BackColor = Color.White;
        //            }

        //            else
        //            {
        //                sublist.ElementAt(j).BackColor = Color.Black;
        //            }
        //        }
        //        this.BoardTiles.Add(sublist);
        //    }
        }
        
        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;

            else
                e.Effect = DragDropEffects.None;


        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Move);
            pictureBox_RemovePicture(sender, e);
        }

        private void pictureBox_RemovePicture(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb = null;
        }
    }

}

