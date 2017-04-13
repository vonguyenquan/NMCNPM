using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mncnpm
{
    public partial class MainWindow : Form
    {   
        //--------------------- VARIABLE INIT ---------------------------------------------
        private bool menuIsExpanded = false;
        private bool loginSuccess = false;
        private Timer timer = new Timer();
        int funcSelect = 0;

        //--------------------- MAIN WINDOW INIT ------------------------------------------
        public MainWindow()
        {
            InitializeComponent();
            //User function
            CollapseMenuBar();
            HideButtonText();
            SetupTimer();
        }
        //
        //--------------------- SUPPORT FUNCTION ------------------------------------------
        //
        private void CollapseMenuBar()
        {
            Layout.ColumnStyles[0].SizeType = SizeType.Absolute;
            Layout.ColumnStyles[0].Width = 50;
            menuIsExpanded = false;
        }      //COLLAPSE the Menu bar
        private void ExpandMenuBar()
        {
            Layout.ColumnStyles[0].SizeType = SizeType.Absolute;
            Layout.ColumnStyles[0].Width = 200;
            menuIsExpanded = true;
        }        //EXPAND the Menu bar
        public void SetLoginSuccess()
        {
            loginSuccess = true;
            btnLogin.Text = "Logout";
            txtStatus.Text = "Đăng nhập thành công";
        }       //SET VARIABLE for SUCCESS LOGIN
        private void TimerEventProcess(object sender, EventArgs e)
        {
            txtStatus.Text = "Sẵn Sàng";
        }   //RESET the state of INFO BAR
        private void SetupTimer()
        {
            timer.Tick += new EventHandler(TimerEventProcess);
            timer.Interval = 5000;
        }
        private void LoginCheck()
        {
            while (loginSuccess == false)
            {
                btnLogin.PerformClick();
                menubar.Enabled = false;
                mainContain.Enabled = false;
            }
        }
        private void HideButtonText()           // Clear all button text when menu bar is COLLAPSE;
        {
            btnMenu.Text = "";
            btnNew.Text = "";
            btnDeposite.Text = "";
            btnWithdraw.Text = "";
            btnList.Text = "";
            btnDayReport.Text = "";
            btnMonthReport.Text = "";
            btnSetting.Text = "";
        }
        private void ShowButtonText()           // Show Button text when EXPANDED
        {
            btnMenu.Text = "MENU";
            btnNew.Text = "          SỔ MỚI";
            btnDeposite.Text = "          GỞI TIỀN";
            btnWithdraw.Text = "          RÚT TIỀN";
            btnList.Text = "      DANH SÁCH SỔ";
            btnDayReport.Text = "      BÁO CÁO NGÀY";
            btnMonthReport.Text = "     BÁO CÁO THÁNG";
            btnSetting.Text = "CÀI ĐẶT";
        }
        private void ClearButtonColor()
        {
            btnNew.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnDeposite.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnWithdraw.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnList.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnDayReport.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnMonthReport.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnSetting.BackColor = System.Drawing.Color.FromArgb(43, 43, 43);
        }
        private void ChangeFormTitle(int sel)
        {
            switch (sel)
            {
                case 1:
                    txtFormName.Text = "Lập Sổ Tiết Kiệm Mới";
                    break;
                case 2:
                    txtFormName.Text = "Phiếu Gởi Tiền";
                    break;
                case 3:
                    txtFormName.Text = "Phiếu Rút Tiền";
                    break;
                case 4:
                    txtFormName.Text = "Danh Sách Sổ Tiết Kiệm";
                    break;
                case 5:
                    txtFormName.Text = "Báo Cáo Doanh Số Hoạt Động Ngày";
                    break;
                case 6:
                    txtFormName.Text = "Báo Cáo Mở/Đóng Sổ Theo Tháng";
                    break;
                case 7:
                    txtFormName.Text = "Cài Đặt";
                    break;
                default:
                    txtFormName.Text = "";
                    break;
            }
        }
        //
        //--------------------- COMPONENT BEHAVIOR ----------------------------------------
        //
        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (menuIsExpanded == false)
            {
                ExpandMenuBar();
                ShowButtonText();
            }
            else
            {
                CollapseMenuBar();
                HideButtonText();
            }
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginSuccess == false)
            {
                LoginForm lf = new LoginForm();
                lf.Show();
            }
            else
            {
                DialogResult logoutResult = MessageBox.Show("Do you want to Logout?", "Informaion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (logoutResult == DialogResult.OK)
                {
                    btnLogin.Text = "Login";
                    menubar.Enabled = false;
                    mainContain.Enabled = false;
                    loginSuccess = false;
                }
             }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (funcSelect != 1)
            {
                funcSelect = 1;
                ChangeFormTitle(funcSelect);
                ClearButtonColor();
                btnNew.BackColor = System.Drawing.Color.FromArgb(168, 210, 153);

                //TODO: Show "new savings-book" usercontrol
            }
        }
        private void btnDeposite_Click(object sender, EventArgs e)
        {
            if (funcSelect != 2)
            {
                funcSelect = 2;
                ChangeFormTitle(funcSelect);
                ClearButtonColor();
                btnDeposite.BackColor = System.Drawing.Color.FromArgb(168, 210, 153);

                //TODO Show "Depositing" usercontrol
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (funcSelect != 3)
            {
                funcSelect = 3;
                ChangeFormTitle(funcSelect);
                ClearButtonColor();
                btnWithdraw.BackColor = System.Drawing.Color.FromArgb(168, 210, 153);

                //TODO Show "Withdraw" usercontrol
            }
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            if (funcSelect != 4)
            {
                funcSelect = 4;
                ChangeFormTitle(funcSelect);
                ClearButtonColor();
                btnList.BackColor = System.Drawing.Color.FromArgb(168, 210, 153);

                //TODO Show "savings-book listing" usercontrol
            }
        }
        private void btnDayReport_Click(object sender, EventArgs e)
        {
            if (funcSelect != 5)
            {
                funcSelect = 5;
                ChangeFormTitle(funcSelect);
                ClearButtonColor();
                btnDayReport.BackColor = System.Drawing.Color.FromArgb(168, 210, 153);

                //TODO Show "Day report" usercontrol
            }
        }
        private void btnMonthReport_Click(object sender, EventArgs e)
        {
            if (funcSelect != 6)
            {
                funcSelect = 6;
                ChangeFormTitle(funcSelect);
                ClearButtonColor();
                btnMonthReport.BackColor = System.Drawing.Color.FromArgb(168, 210, 153);

                //TODO Show "Month Report" usercontrol
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (funcSelect != 7)
            {
                funcSelect = 7;
                ChangeFormTitle(funcSelect);
                ClearButtonColor();
                btnSetting.BackColor = System.Drawing.Color.FromArgb(168, 210, 153);

                // Show "Setting" usercontrol
            }
        }
        private void txtStatus_TextChange(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}