using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManage
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmTrangChu());
            //Application.Run(new frmLogin());
            Application.Run(new frmShipment());
            //Application.Run(new frmTaoTaiKhoan());
            //Application.Run(new frmQuanLyGiaoVien());
            //Application.Run(new frmQuanLyChucVu());
            //Application.Run(new QR_Code());
            //Application.Run(new frmQuanLyLoaiThietBi());
            //Application.Run(new frmQuanLyThietBi());
            //Application.Run(new frmQuanLyTaiKhoan());
        }
    }
}
