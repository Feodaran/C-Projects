using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*jpg,*png|*.bmp;*.jpg;*.png";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.pboOriginal.Image = new Bitmap(ofile.FileName);

            }
            pboOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            pboResult.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void btnGrey_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pboOriginal.Image);

            try
            {
                Processing.ConvertToGrey(copy);
                this.pboResult.Image = copy;
            }
            catch(Exception)
            {
                if (pboOriginal.Image == null)
                {
                    MessageBox.Show("Select an image");
                }
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pboOriginal.Image);
            Processing.ConvertToNegative(copy);
            this.pboResult.Image = copy;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Files(*.png)|*.png";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pboResult.Image.Save(sfd.FileName, ImageFormat.Png);
            }
        }
    }
}
