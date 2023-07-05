using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManage
{
    public static class MessageClass
    {
        public static void Message_Event(string content, string title, bool error)
        {
            if(error)
            {
                MessageBox.Show("Lỗi: " + content, title, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(content, title, MessageBoxButtons.OK);
            }
        }

        public static void Message_CheckData(string content, string title)
        {
            MessageBox.Show(content + " không hợp lệ!", title, MessageBoxButtons.OK);
        }

        public static void Message_Event(string content, string title)
        {
            MessageBox.Show(": " + content, title, MessageBoxButtons.OK);
        }

        public static bool Message_Event_YesNo(string requiment, string title)
        {
            if (MessageBox.Show("Bạn có thật sự muốn "+requiment+"?", "Thông Báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
