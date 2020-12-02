using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

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
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Green;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                lsvBill.Items.Add(lsvItem);
            }
        }

        #endregion
        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin(LoginAccount);
            f.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(loginAccount);
            f.ShowDialog();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }
        #endregion
        bool check = false;
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
                    fCheckOut f = new fCheckOut(table);
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
            fOrderFood f = new fOrderFood();
            f.ShowDialog();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            fSwitchTable f = new fSwitchTable();
            f.ShowDialog();
        }
    }
}
