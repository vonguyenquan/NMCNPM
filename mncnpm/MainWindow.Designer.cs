namespace mncnpm
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.statusBar = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menubar = new System.Windows.Forms.Panel();
            this.mainContain = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMonthReport = new System.Windows.Forms.Button();
            this.btnDayReport = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposite = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Layout.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout.Controls.Add(this.btnMenu, 0, 0);
            this.Layout.Controls.Add(this.statusBar, 1, 0);
            this.Layout.Controls.Add(this.menubar, 0, 1);
            this.Layout.Controls.Add(this.mainContain, 1, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 2;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout.Size = new System.Drawing.Size(1264, 681);
            this.Layout.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusBar.BackColor = System.Drawing.Color.White;
            this.statusBar.Controls.Add(this.txtStatus);
            this.statusBar.Controls.Add(this.txtFormName);
            this.statusBar.Controls.Add(this.btnLogin);
            this.statusBar.Controls.Add(this.picStatus);
            this.statusBar.Location = new System.Drawing.Point(200, 0);
            this.statusBar.Margin = new System.Windows.Forms.Padding(0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1064, 50);
            this.statusBar.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtStatus.Location = new System.Drawing.Point(754, 14);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(84, 25);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "Sẵn Sàng";
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChange);
            // 
            // txtFormName
            // 
            this.txtFormName.AutoSize = true;
            this.txtFormName.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(92)))));
            this.txtFormName.Location = new System.Drawing.Point(0, 2);
            this.txtFormName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(301, 45);
            this.txtFormName.TabIndex = 2;
            this.txtFormName.Text = "Quản Lí Sổ Tiết Kiệm";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.Image = global::mncnpm.Properties.Resources.login;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(941, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 50);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menubar
            // 
            this.menubar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menubar.AutoSize = true;
            this.menubar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.menubar.Controls.Add(this.btnSetting);
            this.menubar.Controls.Add(this.btnMonthReport);
            this.menubar.Controls.Add(this.btnDayReport);
            this.menubar.Controls.Add(this.btnList);
            this.menubar.Controls.Add(this.btnWithdraw);
            this.menubar.Controls.Add(this.btnDeposite);
            this.menubar.Controls.Add(this.btnNew);
            this.menubar.Location = new System.Drawing.Point(0, 50);
            this.menubar.Margin = new System.Windows.Forms.Padding(0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(200, 631);
            this.menubar.TabIndex = 1;
            // 
            // mainContain
            // 
            this.mainContain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mainContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContain.Location = new System.Drawing.Point(200, 50);
            this.mainContain.Margin = new System.Windows.Forms.Padding(0);
            this.mainContain.Name = "mainContain";
            this.mainContain.Size = new System.Drawing.Size(1064, 631);
            this.mainContain.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(153)))));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(140)))), ((int)(((byte)(103)))));
            this.btnMenu.Image = global::mncnpm.Properties.Resources.MenuBtn;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(200, 50);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // picStatus
            // 
            this.picStatus.Image = global::mncnpm.Properties.Resources.done;
            this.picStatus.Location = new System.Drawing.Point(704, 0);
            this.picStatus.Margin = new System.Windows.Forms.Padding(0);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(50, 50);
            this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStatus.TabIndex = 2;
            this.picStatus.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSetting.Image = global::mncnpm.Properties.Resources.setting;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 581);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(200, 50);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "CÀI ĐẶT";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMonthReport
            // 
            this.btnMonthReport.FlatAppearance.BorderSize = 0;
            this.btnMonthReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthReport.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMonthReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnMonthReport.Image = global::mncnpm.Properties.Resources.monthRrport;
            this.btnMonthReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthReport.Location = new System.Drawing.Point(0, 250);
            this.btnMonthReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnMonthReport.Name = "btnMonthReport";
            this.btnMonthReport.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnMonthReport.Size = new System.Drawing.Size(200, 50);
            this.btnMonthReport.TabIndex = 0;
            this.btnMonthReport.Text = "     BÁO CÁO THÁNG";
            this.btnMonthReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthReport.UseVisualStyleBackColor = true;
            this.btnMonthReport.Click += new System.EventHandler(this.btnMonthReport_Click);
            // 
            // btnDayReport
            // 
            this.btnDayReport.FlatAppearance.BorderSize = 0;
            this.btnDayReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDayReport.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDayReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnDayReport.Image = global::mncnpm.Properties.Resources.dayReport;
            this.btnDayReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDayReport.Location = new System.Drawing.Point(0, 200);
            this.btnDayReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnDayReport.Name = "btnDayReport";
            this.btnDayReport.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDayReport.Size = new System.Drawing.Size(200, 50);
            this.btnDayReport.TabIndex = 0;
            this.btnDayReport.Text = "     BÁO CÁO NGÀY";
            this.btnDayReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDayReport.UseVisualStyleBackColor = true;
            this.btnDayReport.Click += new System.EventHandler(this.btnDayReport_Click);
            // 
            // btnList
            // 
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnList.Image = global::mncnpm.Properties.Resources.ListBtn;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(0, 150);
            this.btnList.Margin = new System.Windows.Forms.Padding(0);
            this.btnList.Name = "btnList";
            this.btnList.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnList.Size = new System.Drawing.Size(200, 50);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "     DANH SÁCH SỔ";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnWithdraw.Image = global::mncnpm.Properties.Resources.WithdrawBtn;
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(0, 100);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(0);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(200, 50);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "          RÚT TIỀN";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposite
            // 
            this.btnDeposite.FlatAppearance.BorderSize = 0;
            this.btnDeposite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposite.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeposite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnDeposite.Image = global::mncnpm.Properties.Resources.DepoBtn;
            this.btnDeposite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposite.Location = new System.Drawing.Point(0, 50);
            this.btnDeposite.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDeposite.Size = new System.Drawing.Size(200, 50);
            this.btnDeposite.TabIndex = 0;
            this.btnDeposite.Text = "          GỞI TIỀN";
            this.btnDeposite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposite.UseVisualStyleBackColor = true;
            this.btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnNew.Image = global::mncnpm.Properties.Resources.NewBtn;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(200, 50);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "          SỔ MỚI";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Layout);
            this.Name = "MainWindow";
            this.Text = "Quản lí Sổ tiết kiệm";
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menubar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.ResumeLayout(false);

        }

        private void TxtStatus_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel menubar;
        private System.Windows.Forms.Panel statusBar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label txtFormName;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.PictureBox picStatus;
        private System.Windows.Forms.Panel mainContain;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMonthReport;
        private System.Windows.Forms.Button btnDayReport;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposite;
    }
}

