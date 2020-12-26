using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.DAO;
using System.IO;

namespace QuanLyQuanCafe
{
    public partial class FoodDetails : Form
    {
        public FoodDetails()
        {
            InitializeComponent();
        }
        int foodid;
        string nName;
        int category;
        float price;
        byte[] image;

        public int FoodID
        {
            get { return foodid; }
            set { foodid = value; }
        }
        public string FoodName
        {
            get { return nName; }
            set { nName = value; }
        }
        public int Category
        {
            get { return category; }
            set { category = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public byte[] FoodImage
        {
            get { return image; }
            set { image = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsAdd())
            {
                nName = txbFoodName.Text;
                category = (cbFoodCategory.SelectedItem as Category).ID;
                price = Convert.ToInt32(txbPrice.Text);
                if (pbFoodImage.Image != null)
                    image = ImageToByteArray(pbFoodImage.Image);
                else
                {
                    string file = "DefaltImage.png";
                    Image foodimage = Image.FromFile(file);
                    image = ImageToByteArray(foodimage);
                }    


            }
            this.Close();
        }
        private void FoodDetails_Load(object sender, EventArgs e)
        {

        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbFoodImage.Image = Image.FromFile(open.FileName);
            }

        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        public bool IsAdd()
        {
            if (string.IsNullOrEmpty(txbFoodName.Text) || string.IsNullOrEmpty(txbPrice.Text))
            {
                return false;
            }
            else return true;
        }

        public bool IsChannged(string fname, int fcategory, float fprice,byte[] img)
        {
            if (nName == fname && category == fcategory && price == fprice && image == img)
                return false;
            else
            {
                return true;
            }
        }

        private void txbFoodName_TextChanged(object sender, EventArgs e)
        {
            LoadCategoryIntoCombobox(cbFoodCategory);
        }
        public void LoadFood(int fid, string fname, int fcategory, float fprice)
        {
            txbID.Text = fid.ToString();
            txbFoodName.Text = fname;
            Category fcategoryid = CategoryDAO.Instance.GetCategoryByID(fcategory);
            cbFoodCategory.SelectedItem = fcategoryid;
            int Index = -1, i = 0;
            foreach (Category item in cbFoodCategory.Items)



            {
                if (item.ID == fcategoryid.ID)
                {
                    Index = i;
                    break;
                }
                i++;
            }
            cbFoodCategory.SelectedIndex = Index;
            txbPrice.Text = fprice.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            pbFoodImage.Image = FoodDAO.Instance.getimagebyid(Convert.ToInt32(txbID.Text));
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            FoodDAO.Instance.UpdateFoodImage(ImageToByteArray(pbFoodImage.Image), txbFoodName.Text);
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbFoodCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
