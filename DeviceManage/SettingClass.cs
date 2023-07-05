using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace DeviceManage
{
    public static class SettingClass
    {
        #region Path
        public static string path_Folder_Resource = Path.GetFullPath("../../Resources/");
        public static string path_Folder_QR_Image = Path.GetFullPath("../../Resources/QR/");
        public static string path_Folder_Default_Image = Path.GetFullPath("../../Resources/DefaultImage/");
        public static string path_Folder_Image_Device = Path.GetFullPath("../../Resources/ImageDevice/");
        public static string path_Image_Device_Default = Path.GetFullPath("../../Resources/DefaultImage/pc.jpg");
        public static string path_NoImage_Default = Path.GetFullPath("../../Resources/DefaultImage/no_image1.png");
        public static string path_ErrorFile_Default = Path.GetFullPath("../../Resources/DefaultImage/file_error.jpg");
        #endregion

        #region Title
        public static string TextTitle_ThongBao = "Thông báo";
        public static string TextTitle_Warning = "Cảnh báo!";
        #endregion

        public static string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");//Nếu là "X2" thì kết quả sẽ tự chuyển sang ký tự in Hoa
            }

            return str_md5;
        }
    }
}
