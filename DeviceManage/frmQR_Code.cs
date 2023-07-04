using QRCoder;
using BUS.BusinessObject;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceManage
{
    public partial class frmQR_Code : Form
    {
        public string info; 
        public frmQR_Code(string info)
        {
            InitializeComponent();
            this.info = info;
            ptb_show.SizeMode = PictureBoxSizeMode.Zoom;
            show_QR();
        }

        private void show_QR()
        {
            //Random R = new Random();
            //int QR = R.Next(100, 1000);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(4);

            ptb_show.Image = qrCodeImage;
        }

        public void UploadImage()
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            //Khoi tao thiet lap cho dialog
            open.InitialDirectory = "C:\\Windows\\";
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                if ((stream = open.OpenFile()) != null)
                {
                    // display image in picture box  
                    //pictureBox1.Image = new Bitmap(open.FileName);
                    // image file path  
                    //textBox1.Text = open.FileName;
                    
                }
                stream.Close();
                stream.Dispose();
                GC.Collect();

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            //Khoi tao thiet lap cho dialog
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                if ((stream = open.OpenFile()) != null)
                {
                    ptb_show.Image = Image.FromStream(stream);
                }
                stream.Close();
                stream.Dispose();
                GC.Collect();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ptb_show.Image != null)
            {
                string fileName = ((DateTime.Now.ToString().Replace("/", "-")).Replace(":", "")).Replace(" ", "_") + "_" + "QR1.jpg";
                ptb_show.Image.Save(SettingClass.path_Folder_QR_Image + fileName, ImageFormat.Jpeg);
            }
            //MessageBox.Show(SettingClass.path_QR_Image);
            
        }
    }
}
