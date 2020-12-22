using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.FormChildren;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }
            set
            {
                loginAccount = value;
                ChangeAccount(LoginAccount.Type);
            }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();

            // Hiện tổng tiền bằng 0;
            float money = 0;
            CultureInfo culture = new CultureInfo("vi-VN");
            lbTotalPrice.Text = money.ToString("c", culture);
        }
        #region Method
        void ChangeAccount(int type)
        {
            if (type == 1)
                btnAdmin.Hide();
            lbInfoUser.Text =  LoginAccount.DisplayName;
        }
        void LoadTable()
        {
            List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Arial", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                btn.ForeColor = Color.Black;
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.PaleGreen;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
        }

        #endregion
        #region Event
        bool check = false;
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            check = true;
            LoadtotalPrice(tableID);
            lbNameFood.Text = ((sender as Button).Tag as Table).Name;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin(LoginAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
            flpTable.Controls.Clear();
            LoadTable();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(loginAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
            lbInfoUser.Text = loginAccount.DisplayName;
        }

        
        #endregion

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (check)
            {
                if (table.Status == "Trống")
                {
                    MessageBox.Show("Không thể thanh toán bàn trống !");
                }    
                else
                {
                    fCheckOut f = new fCheckOut(table,loginAccount);
                    f.ShowDialog();
                    flpTable.Controls.Clear();
                    this.LoadTable();
                    this.ShowBill(table.ID);
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn !");
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (check)
            {
                fOrderFood f = new fOrderFood(table);
                f.ShowDialog();
                flpTable.Controls.Clear();
                this.LoadTable();
                this.ShowBill(table.ID);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn !");
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (check)
            {
                if (table.Status == "Trống")
                {
                    MessageBox.Show("Bàn đang trống !");
                }
                else
                {
                    fSwitchTable f = new fSwitchTable(table);
                    f.ShowDialog();
                    flpTable.Controls.Clear();
                    this.LoadTable();
                    this.ShowBill(table.ID);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn !");
            }
        }

        void LoadtotalPrice(int id)
        {
            float TotalPrice = 0;
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            foreach (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
            {
                TotalPrice += item.TotalPrice;
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            lbTotalPrice.Text = TotalPrice.ToString("c", culture);

        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
           
            fMergeTable f = new fMergeTable();
            f.ShowDialog();
            flpTable.Controls.Clear();
            this.LoadTable();

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            fNotification f = new fNotification();
            f.ShowDialog();
        }
    }
}
