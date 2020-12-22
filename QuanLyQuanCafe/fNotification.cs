using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace QuanLyQuanCafe
{
    public partial class fNotification : Form
    {
        int time = 0;
        Timer t;
        bool isclick = false;

        WindowsMediaPlayer sound1;
        WindowsMediaPlayer sound2;

        bool isplay = false;
        public fNotification()
        {
            InitializeComponent();
            sound1 = new WindowsMediaPlayer();
            sound2 = new WindowsMediaPlayer();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isclick == false)
            {
                isclick = true;
                t = new Timer();
                t.Interval = 1000;

                Speak1();
                t.Start();
                t.Tick += T_Tick;
            }    
            else
            {
                MessageBox.Show("Vui lòng đợi 30s từ lần nhấn đầu tiên để nhấn tiếp !");
            }    
            
        }

        private void T_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 7)
            {
                Speak2();
            }
            if (time == 30)
            {
                isclick = false;
                t.Stop();
                time = 0;
            }    
        }

        private void Speak1()
        {
            string path = Path.GetFullPath(@"..\..\Sound\NhacDao.mp3");
            sound1.URL = path;
            sound1.controls.play();
        }

        private void Speak2()
        {
            
            string path;
            switch(comboBox1.SelectedItem.ToString())
            {
                case "Thông báo đóng cửa":
                    path = Path.GetFullPath(@"..\..\Sound\DongCua.mp3");
                    sound2.URL = path;
                    sound2.controls.play();
                    break;
                case "Thông báo nhận ví":
                    path = Path.GetFullPath(@"..\..\..\Sound\Vi.mp3");
                    sound2.URL = path;
                    sound2.controls.play();
                    break;
                case "Thông báo nhận điện thoại":
                    path = Path.GetFullPath(@"..\..\Sound\DienThoai.mp3");
                    sound2.URL = path;
                    sound2.controls.play();
                    break;
            }
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
