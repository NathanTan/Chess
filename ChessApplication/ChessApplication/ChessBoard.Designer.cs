namespace ChessApplication
{
    partial class ChessBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessBoard));
            this.pictureBoxA8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxB8 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxA7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxC8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB8)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA8
            // 
            this.pictureBoxA8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxA8.Image")));
            this.pictureBoxA8.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxA8.Name = "pictureBoxA8";
            this.pictureBoxA8.Size = new System.Drawing.Size(144, 125);
            this.pictureBoxA8.TabIndex = 0;
            this.pictureBoxA8.TabStop = false;
            // 
            // pictureBoxB8
            // 
            this.pictureBoxB8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxB8.Image")));
            this.pictureBoxB8.Location = new System.Drawing.Point(153, 3);
            this.pictureBoxB8.Name = "pictureBoxB8";
            this.pictureBoxB8.Size = new System.Drawing.Size(150, 125);
            this.pictureBoxB8.TabIndex = 1;
            this.pictureBoxB8.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxC8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxA7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxA8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxB8, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(296, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 262);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBoxA7
            // 
            this.pictureBoxA7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxA7.Image")));
            this.pictureBoxA7.Location = new System.Drawing.Point(3, 134);
            this.pictureBoxA7.Name = "pictureBoxA7";
            this.pictureBoxA7.Size = new System.Drawing.Size(144, 125);
            this.pictureBoxA7.TabIndex = 3;
            this.pictureBoxA7.TabStop = false;
            // 
            // pictureBoxC8
            // 
            this.pictureBoxC8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxC8.Image")));
            this.pictureBoxC8.Location = new System.Drawing.Point(334, 3);
            this.pictureBoxC8.Name = "pictureBoxC8";
            this.pictureBoxC8.Size = new System.Drawing.Size(171, 125);
            this.pictureBoxC8.TabIndex = 3;
            this.pictureBoxC8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(546, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ChessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 886);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChessBoard";
            this.Text = "ChessBoard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB8)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA8;
        private System.Windows.Forms.PictureBox pictureBoxB8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxA7;
        private System.Windows.Forms.PictureBox pictureBoxC8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}