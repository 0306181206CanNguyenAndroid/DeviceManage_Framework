using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManage
{
    public partial class frmBaoCaoThongKe : Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void thốngKêThiếtBịTheoPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportThietBiTheoPhong thietBiTheoPhong = new reportThietBiTheoPhong();
            thietBiTheoPhong.TopLevel = false;
            thietBiTheoPhong.AutoScroll = true;
            thietBiTheoPhong.Dock= DockStyle.Fill;
            this.pnContent.Controls.Add(thietBiTheoPhong);
            thietBiTheoPhong.Show();
        }
    }
}
