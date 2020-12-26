using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyQuanCafe.FormChildren
{
    public partial class AccountDetails : Form
    {
        int type_;
        public AccountDetails(int t)
        {
            InitializeComponent();
            type_ = t;
        }
        private string uname;
        private string dname;
        private int type;
        private byte[] image;
        public bool IsEdit;
        public string UserName
        {
            get { return uname; }
            set { uname = value; }
        }

        public string DisplayName
        {
            get { return dname; }
            set { dname = value; }
        }

        public int AccountType
        {
            get { return type; }
            set { type = value; }
        }

        public byte[] AccountImage
        {
            get { return image; }
            set { image = value; }
        }


        private void nmAccountType_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsAdd())
            {
                if (UserAccount.Instance.Check(txbAccountName.Text) == 1 || this.IsEdit == true)
                {
                    if (UserAccount.Instance.Check(txbAccountName.Text) == 1)
                    {
                        Save();
                        this.Close();
                    }                
                    else
                    {
                        int tmp = (int)nmAccountType.Value;
                        if (UserAccount.Instance.DemTaiKhoanQL() == 1 && type_ == 0 && tmp == 1)
                        {
                            MessageBox.Show("Cần ít nhất 1 tài khoản lại quản lý !");
                        }    
                        else
                        {
                            Save();
                            this.Close();
                        }    
                    }    
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            
        }

        void Save()
        {
            uname = txbAccountName.Text;
            dname = txbDisplayName.Text;
            type = (int)nmAccountType.Value;
            if (ptbPicture.Image != null)
            {
                image = ImageToByteArray(ptbPicture.Image);
            }   
            else
            {
                string file = "DefaltAccountPic.png";
                Image foodimage = Image.FromFile(file);
                image = ImageToByteArray(foodimage);
            }
        }
        public bool IsAdd()
        {
            if (string.IsNullOrEmpty(txbDisplayName.Text) || string.IsNullOrEmpty(nmAccountType.Text) || string.IsNullOrEmpty(txbAccountName.Text))
            {
                return false;
            }
            else return true;
        }
        public bool IsChannged(string funame,string fdname, int ftype,byte[] fimg)
        {
            byte[] img = ImageToByteArray(ptbPicture.Image);
            if (uname == funame && dname == fdname && type == ftype && img.Equals(fimg))
                return false;
            else
            {
                return true;
            }
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        public void LoadAccount(string fid, string fname,int ftype)
        {
            txbAccountName.Text = fid;
            txbDisplayName.Text = fname;
            nmAccountType.Text = ftype.ToString();
            txbAccountName.ReadOnly = true;
        }


        private void txbAccountName_TextChanged(object sender, EventArgs e)
        {
            if (IsEdit == true)
            {
                ptbPicture.Image = UserAccount.Instance.GetImageByName(txbAccountName.Text);
            }
        }

        private void AccountDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbPicture.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
