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

        WindowsMediaPlayer sound;

        bool isplay = false;
        public fNotification()
        {
            InitializeComponent();
            sound = new WindowsMediaPlayer();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isclick == false)
            {
                isclick = true;
                t = new Timer();
                t.Interval = 1000;

                Speak();
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
            if (time == 30)
            {
                isclick = false;
                t.Stop();
                time = 0;
            }    
        }

        private void Speak()
        {
            
            string path;
            switch(comboBox1.SelectedItem.ToString())
            {
                case "Thông báo đóng cửa":
                    path = Path.GetFullPath(@"..\..\Sound\DongCua.mp3");
                    sound.URL = path;
                    sound.controls.play();
                    break;
                case "Thông báo nhận ví":
                    path = Path.GetFullPath(@"..\..\..\Sound\Vi.mp3");
                    sound.URL = path;
                    sound.controls.play();
                    break;
                case "Thông báo nhận điện thoại":
                    path = Path.GetFullPath(@"..\..\Sound\DienThoai.mp3");
                    sound.URL = path;
                    sound.controls.play();
                    break;
            }
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void fNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.sound.controls.stop();
            
        }
    }
}
