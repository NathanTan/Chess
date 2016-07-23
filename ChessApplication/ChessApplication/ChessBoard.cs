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
    public partial class ChessBoard : Form
    {
        public ChessBoard()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChessBoard_Load(object sender, EventArgs e)
        {

            //For Dragging and Dropping of all chess pieces
            pictureBoxA1.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA1.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA2.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA2.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA3.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA3.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA4.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA4.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA5.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA5.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA6.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA6.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA7.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA7.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA8.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxA8.DragDrop += new DragEventHandler(pictureBox_DragEnter);

            pictureBoxB1.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB1.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB2.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB2.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB3.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB3.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB4.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB4.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB5.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB5.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB6.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB6.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB7.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB7.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB8.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxB8.DragDrop += new DragEventHandler(pictureBox_DragEnter);

            pictureBoxC1.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC1.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC2.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC2.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC3.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC3.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC4.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC4.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC5.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC5.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC6.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC6.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC7.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC7.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC8.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxC8.DragDrop += new DragEventHandler(pictureBox_DragEnter);

            pictureBoxD1.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD1.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD2.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD2.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD3.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD3.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD4.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD4.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD5.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD5.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD6.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD6.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD7.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD7.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD8.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxD8.DragDrop += new DragEventHandler(pictureBox_DragEnter);

            pictureBoxE1.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE1.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE2.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE2.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE3.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE3.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE4.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE4.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE5.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE5.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE6.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE6.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE7.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE7.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE8.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxE8.DragDrop += new DragEventHandler(pictureBox_DragEnter);

            pictureBoxF1.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF1.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF2.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF2.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF3.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF3.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF4.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF4.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF5.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF5.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF6.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF6.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF7.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF7.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF8.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxF8.DragDrop += new DragEventHandler(pictureBox_DragEnter);

            pictureBoxG1.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG1.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG2.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG2.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG3.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG3.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG4.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG4.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG5.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG5.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG6.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG6.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG7.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG7.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG8.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxG8.DragDrop += new DragEventHandler(pictureBox_DragEnter);

            pictureBoxH1.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH1.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH2.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH2.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH3.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH3.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH4.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH4.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH5.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH5.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH6.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH6.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH7.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH7.DragDrop += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH8.DragEnter += new DragEventHandler(pictureBox_DragEnter);
            pictureBoxH8.DragDrop += new DragEventHandler(pictureBox_DragEnter);

            pictureBoxA1.AllowDrop = true;
            pictureBoxA2.AllowDrop = true;
            pictureBoxA3.AllowDrop = true;
            pictureBoxA4.AllowDrop = true;
            pictureBoxA5.AllowDrop = true;
            pictureBoxA6.AllowDrop = true;
            pictureBoxA7.AllowDrop = true;
            pictureBoxA8.AllowDrop = true;

            pictureBoxB1.AllowDrop = true;
            pictureBoxB2.AllowDrop = true;
            pictureBoxB3.AllowDrop = true;
            pictureBoxB4.AllowDrop = true;
            pictureBoxB5.AllowDrop = true;
            pictureBoxB6.AllowDrop = true;
            pictureBoxB7.AllowDrop = true;
            pictureBoxB8.AllowDrop = true;

            pictureBoxC1.AllowDrop = true;
            pictureBoxC2.AllowDrop = true;
            pictureBoxC3.AllowDrop = true;
            pictureBoxC4.AllowDrop = true;
            pictureBoxC5.AllowDrop = true;
            pictureBoxC6.AllowDrop = true;
            pictureBoxC6.AllowDrop = true;
            pictureBoxC7.AllowDrop = true;
            pictureBoxC8.AllowDrop = true;

            pictureBoxD1.AllowDrop = true;
            pictureBoxD2.AllowDrop = true;
            pictureBoxD3.AllowDrop = true;
            pictureBoxD4.AllowDrop = true;
            pictureBoxD5.AllowDrop = true;
            pictureBoxD6.AllowDrop = true;
            pictureBoxD6.AllowDrop = true;
            pictureBoxD7.AllowDrop = true;
            pictureBoxD8.AllowDrop = true;

            pictureBoxE1.AllowDrop = true;
            pictureBoxE2.AllowDrop = true;
            pictureBoxE3.AllowDrop = true;
            pictureBoxE4.AllowDrop = true;
            pictureBoxE5.AllowDrop = true;
            pictureBoxE6.AllowDrop = true;
            pictureBoxE6.AllowDrop = true;
            pictureBoxE7.AllowDrop = true;
            pictureBoxE8.AllowDrop = true;

            pictureBoxF1.AllowDrop = true;
            pictureBoxF2.AllowDrop = true;
            pictureBoxF3.AllowDrop = true;
            pictureBoxF4.AllowDrop = true;
            pictureBoxF5.AllowDrop = true;
            pictureBoxF6.AllowDrop = true;
            pictureBoxF6.AllowDrop = true;
            pictureBoxF7.AllowDrop = true;
            pictureBoxF8.AllowDrop = true;

            pictureBoxG1.AllowDrop = true;
            pictureBoxG2.AllowDrop = true;
            pictureBoxG3.AllowDrop = true;
            pictureBoxG4.AllowDrop = true;
            pictureBoxG5.AllowDrop = true;
            pictureBoxG6.AllowDrop = true;
            pictureBoxG6.AllowDrop = true;
            pictureBoxG7.AllowDrop = true;
            pictureBoxG8.AllowDrop = true;

            pictureBoxH1.AllowDrop = true;
            pictureBoxH2.AllowDrop = true;
            pictureBoxH3.AllowDrop = true;
            pictureBoxH4.AllowDrop = true;
            pictureBoxH5.AllowDrop = true;
            pictureBoxH6.AllowDrop = true;
            pictureBoxH6.AllowDrop = true;
            pictureBoxH7.AllowDrop = true;
            pictureBoxH8.AllowDrop = true;

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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
