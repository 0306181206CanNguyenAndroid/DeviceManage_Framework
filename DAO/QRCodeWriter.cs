using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace DAO
{
    class QRCodeWriterClass
    {
        //public static Bitmap GenerateQRCode(string content, int width, int height)
        //{
        //    var options = new EncodingOptions
        //    {
        //        Width = width,
        //        Height = height,
        //        Margin = 0
        //    };

        //    var writer = new BarcodeWriterPixelData
        //    {
        //        Format = BarcodeFormat.QR_CODE,
        //        Options = options
        //    };

        //    var pixelData = writer.Write(content);
        //    var bitmap = new Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppRgb);

        //    BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
        //    Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
        //    bitmap.UnlockBits(bitmapData);

        //    return bitmap;
       // }

        /*
        public void Create_QR(String Device)
        {

            // Create an instance of the BarcodeWriter class
            var barcodeWriter = new BarcodeWriter();

            // Set the format of the barcode writer to QR_CODE
            barcodeWriter.Format = BarcodeFormat.QR_CODE;

            // Create an instance of the QRCodeWriter class
            var writer = new BarcodeWriter();

            // Create an instance of the BitMatrix class
            var matrix = writer.Encode(Device);

           

            // Set the options of the barcode writer
            var options = new EncodingOptions
            {
                Margin = 1,
                ErrorCorrection = ErrorCorrectionLevel.H
            };
            barcodeWriter.Options = options;

            // Create a bitmap image
            var bitmap = barcodeWriter.Write(matrix);

            // Save the bitmap image to a file
            bitmap.Save("qrcode.png");
        }
        */
    }
}
