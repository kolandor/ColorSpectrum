using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSpectrum
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        void SetSaveButtonsState(bool state)
        {
            buttonSRed.Enabled = buttonSBlue.Enabled = buttonSGreen.Enabled = buttonSMono.Enabled = state;
        }

        private void buttonOpenImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(ofd.FileName))
                    {
                        Bitmap selectedImage = (Bitmap)Image.FromFile(ofd.FileName);

                        pictureBoxOrig.Image = selectedImage;

                        pictureBoxRed.Image = GetSpecterFromImage(selectedImage, Specter.Red);
                        pictureBoxGreen.Image = GetSpecterFromImage(selectedImage, Specter.Green);
                        pictureBoxBlue.Image = GetSpecterFromImage(selectedImage, Specter.Blue);
                        pictureBoxMono.Image = GetSpecterFromImage(selectedImage, Specter.Mono);

                        SetSaveButtonsState(true);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Bitmap GetSpecterFromImage(Bitmap bitmap, Specter specter)
        {
            Bitmap newImageFromSpecter = new Bitmap(bitmap.Width, bitmap.Height);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelOrig = bitmap.GetPixel(x, y);

                    if (specter == Specter.Red)
                    {
                        pixelOrig = Color.FromArgb(pixelOrig.R, 0, 0);
                    }
                    else if (specter == Specter.Green)
                    {
                        pixelOrig = Color.FromArgb(0, pixelOrig.G, 0);
                    }
                    else if(specter == Specter.Blue)
                    {
                        pixelOrig = Color.FromArgb(0, 0, pixelOrig.B);
                    }
                    else
                    {
                        int monoColor = (pixelOrig.R + pixelOrig.G + pixelOrig.B) / 3;

                        /*if(monoColor > (byte.MaxValue / 2) + 5)
                        {
                            pixelOrig = Color.FromArgb(255, 255, 255);
                        }
                        else
                        {
                            pixelOrig = Color.FromArgb(0, 0, 0);
                        }*/

                        pixelOrig = Color.FromArgb(monoColor, monoColor, monoColor);
                    }

                    newImageFromSpecter.SetPixel(x, y, pixelOrig);
                }
            }

            return newImageFromSpecter;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Images|*.png;*.bmp;*.jpg";

                sfd.FileName = ((Control)sender).Name;

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    if (sender == buttonSRed)
                    {
                        pictureBoxRed.Image.Save(sfd.FileName, ImageFormat.Png);
                    }
                    else if (sender == buttonSGreen)
                    {
                        pictureBoxGreen.Image.Save(sfd.FileName, ImageFormat.Png);
                    }
                    else if (sender == buttonSBlue)
                    {
                        pictureBoxBlue.Image.Save(sfd.FileName, ImageFormat.Png);
                    }
                    else
                    {
                        pictureBoxMono.Image.Save(sfd.FileName, ImageFormat.Png);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
