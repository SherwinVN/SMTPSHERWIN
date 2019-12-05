namespace SMTPSHERWIN
{
    partial class frm_smtpsherwin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_smtpsherwin));
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.but_dang_nhap = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.but_gui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email_nguoi_nhan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ten_nguoi_nhan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.htmledit = new SpiceLogic.WinHTMLEditor.WinForm.WinFormHtmlEditor();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ten_hien_thi = new System.Windows.Forms.TextBox();
            this.chk_guitd = new System.Windows.Forms.CheckBox();
            this.but_lay_ds = new System.Windows.Forms.Button();
            this.gv_list = new System.Windows.Forms.DataGridView();
            this.colstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_list = new System.Windows.Forms.ComboBox();
            this.txt_tg_p = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.but_stop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txt_tg_s = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.lab_so_lan_gui = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_max = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.lab_thanhcong = new System.Windows.Forms.Label();
            this.lab_thatbai = new System.Windows.Forms.Label();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.chk_ssl = new System.Windows.Forms.CheckBox();
            this.gv_email = new System.Windows.Forms.DataGridView();
            this.colstatus2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_lay_email = new System.Windows.Forms.Button();
            this.cb_email = new System.Windows.Forms.ComboBox();
            this.chk_radom_email = new System.Windows.Forms.CheckBox();
            this.pgb_main = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.htmledit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tg_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tg_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_email)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(70, 11);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(137, 20);
            this.txt_server.TabIndex = 0;
            this.txt_server.TextChanged += new System.EventHandler(this.txt_server_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(70, 33);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(217, 20);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(70, 55);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(217, 20);
            this.txt_password.TabIndex = 3;
            // 
            // but_dang_nhap
            // 
            this.but_dang_nhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_dang_nhap.Location = new System.Drawing.Point(70, 103);
            this.but_dang_nhap.Name = "but_dang_nhap";
            this.but_dang_nhap.Size = new System.Drawing.Size(78, 23);
            this.but_dang_nhap.TabIndex = 5;
            this.but_dang_nhap.Text = "Đăng nhập";
            this.but_dang_nhap.UseVisualStyleBackColor = true;
            this.but_dang_nhap.Click += new System.EventHandler(this.But_dang_nhap_Click);
            // 
            // txt_title
            // 
            this.txt_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_title.Location = new System.Drawing.Point(70, 212);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(396, 20);
            this.txt_title.TabIndex = 14;
            // 
            // but_gui
            // 
            this.but_gui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but_gui.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_gui.Location = new System.Drawing.Point(60, 408);
            this.but_gui.Name = "but_gui";
            this.but_gui.Size = new System.Drawing.Size(75, 23);
            this.but_gui.TabIndex = 15;
            this.but_gui.Text = "Gửi";
            this.but_gui.UseVisualStyleBackColor = true;
            this.but_gui.Click += new System.EventHandler(this.But_gui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tiêu đề";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nội dung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Port";
            // 
            // txt_email_nguoi_nhan
            // 
            this.txt_email_nguoi_nhan.Location = new System.Drawing.Point(70, 190);
            this.txt_email_nguoi_nhan.Name = "txt_email_nguoi_nhan";
            this.txt_email_nguoi_nhan.Size = new System.Drawing.Size(169, 20);
            this.txt_email_nguoi_nhan.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Email to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nội dung gửi";
            // 
            // txt_ten_nguoi_nhan
            // 
            this.txt_ten_nguoi_nhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ten_nguoi_nhan.Location = new System.Drawing.Point(293, 189);
            this.txt_ten_nguoi_nhan.Name = "txt_ten_nguoi_nhan";
            this.txt_ten_nguoi_nhan.Size = new System.Drawing.Size(173, 20);
            this.txt_ten_nguoi_nhan.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.htmledit);
            this.groupBox1.Location = new System.Drawing.Point(70, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // htmledit
            // 
            this.htmledit.AllowWebInEditorNavigationInPreview = false;
            this.htmledit.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.htmledit.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.htmledit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.htmledit.BackgroundImagePath = "";
            this.htmledit.BaseUrl = "";
            this.htmledit.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.htmledit.BodyHtml = "";
            this.htmledit.BodyStyle = "";
            this.htmledit.Charset = "unicode";
            this.htmledit.DefaultForeColor = System.Drawing.Color.Black;
            this.htmledit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmledit.DocumentCSSFilePath = "";
            this.htmledit.DocumentHtml = resources.GetString("htmledit.DocumentHtml");
            this.htmledit.DocumentTitle = "";
            this.htmledit.EditorContextMenuStrip = null;
            this.htmledit.Location = new System.Drawing.Point(3, 16);
            this.htmledit.Name = "htmledit";
            this.htmledit.Options.ConvertFileUrlsToLocalPaths = true;
            this.htmledit.Options.FooterTagNavigatorFont = null;
            this.htmledit.Options.FooterTagNavigatorTextColor = System.Drawing.Color.Teal;
            this.htmledit.Options.FTPSettingsForRemoteResources.Host = null;
            this.htmledit.Options.FTPSettingsForRemoteResources.Password = null;
            this.htmledit.Options.FTPSettingsForRemoteResources.RemoteFolderPath = null;
            this.htmledit.Options.FTPSettingsForRemoteResources.UrlOfTheRemoteFolderPath = null;
            this.htmledit.Options.FTPSettingsForRemoteResources.UserName = null;
            this.htmledit.Options.YouTubeVideoIFrameDefaultCSS = "border:1px;border-style:solid;border-color:gray;";
            this.htmledit.ScrollBarSetting = SpiceLogic.HtmlEditorControl.Domain.BOs.ScrollBarVisibility.Default;
            this.htmledit.Size = new System.Drawing.Size(697, 145);
            this.htmledit.SpellCheckOptions.DictionaryFilePath = null;
            this.htmledit.SpellCheckOptions.SuggestionMode = SpiceLogic.HtmlEditorControl.FrameworkExtensions.SpellCheck.NetSpell.Spelling.SuggestionEnum.PhoneticNearMiss;
            this.htmledit.SpellCheckOptions.WaitAlertMessage = "Searching next messpelled word..... (please wait)";
            this.htmledit.TabIndex = 0;
            // 
            // htmledit.WinFormHtmlEditor_Toolbar1
            // 
            this.htmledit.Toolbar1.Location = new System.Drawing.Point(0, 0);
            this.htmledit.Toolbar1.Name = "WinFormHtmlEditor_Toolbar1";
            this.htmledit.Toolbar1.Size = new System.Drawing.Size(697, 29);
            this.htmledit.Toolbar1.TabIndex = 0;
            // 
            // htmledit.WinFormHtmlEditor_Toolbar2
            // 
            this.htmledit.Toolbar2.Location = new System.Drawing.Point(0, 29);
            this.htmledit.Toolbar2.Name = "WinFormHtmlEditor_Toolbar2";
            this.htmledit.Toolbar2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.htmledit.Toolbar2.Size = new System.Drawing.Size(697, 29);
            this.htmledit.Toolbar2.TabIndex = 0;
            this.htmledit.ToolbarContextMenuStrip = null;
            // 
            // htmledit.WinFormHtmlEditor_ToolbarFooter
            // 
            this.htmledit.ToolbarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.htmledit.ToolbarFooter.Location = new System.Drawing.Point(0, 120);
            this.htmledit.ToolbarFooter.Name = "WinFormHtmlEditor_ToolbarFooter";
            this.htmledit.ToolbarFooter.Size = new System.Drawing.Size(697, 25);
            this.htmledit.ToolbarFooter.TabIndex = 7;
            this.htmledit.z__ignore = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(3, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Hiển thị";
            // 
            // txt_ten_hien_thi
            // 
            this.txt_ten_hien_thi.Location = new System.Drawing.Point(70, 77);
            this.txt_ten_hien_thi.Name = "txt_ten_hien_thi";
            this.txt_ten_hien_thi.Size = new System.Drawing.Size(217, 20);
            this.txt_ten_hien_thi.TabIndex = 4;
            // 
            // chk_guitd
            // 
            this.chk_guitd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_guitd.AutoSize = true;
            this.chk_guitd.BackColor = System.Drawing.Color.Transparent;
            this.chk_guitd.Location = new System.Drawing.Point(141, 412);
            this.chk_guitd.Name = "chk_guitd";
            this.chk_guitd.Size = new System.Drawing.Size(82, 17);
            this.chk_guitd.TabIndex = 16;
            this.chk_guitd.Text = "Gửi tự động";
            this.chk_guitd.UseVisualStyleBackColor = false;
            // 
            // but_lay_ds
            // 
            this.but_lay_ds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_lay_ds.Location = new System.Drawing.Point(470, 11);
            this.but_lay_ds.Name = "but_lay_ds";
            this.but_lay_ds.Size = new System.Drawing.Size(129, 23);
            this.but_lay_ds.TabIndex = 10;
            this.but_lay_ds.Text = "Lấy danh sách";
            this.but_lay_ds.UseVisualStyleBackColor = true;
            this.but_lay_ds.Click += new System.EventHandler(this.But_lay_ds_Click);
            // 
            // gv_list
            // 
            this.gv_list.AllowUserToAddRows = false;
            this.gv_list.AllowUserToOrderColumns = true;
            this.gv_list.AllowUserToResizeRows = false;
            this.gv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstatus,
            this.colten,
            this.colemail});
            this.gv_list.Location = new System.Drawing.Point(472, 38);
            this.gv_list.MultiSelect = false;
            this.gv_list.Name = "gv_list";
            this.gv_list.ReadOnly = true;
            this.gv_list.Size = new System.Drawing.Size(295, 194);
            this.gv_list.TabIndex = 30;
            this.gv_list.SelectionChanged += new System.EventHandler(this.Gv_list_SelectionChanged);
            // 
            // colstatus
            // 
            this.colstatus.DataPropertyName = "colstatus";
            this.colstatus.FillWeight = 80F;
            this.colstatus.HeaderText = "Trạng thái";
            this.colstatus.Name = "colstatus";
            this.colstatus.ReadOnly = true;
            this.colstatus.Width = 80;
            // 
            // colten
            // 
            this.colten.DataPropertyName = "colten";
            this.colten.HeaderText = "Tên Email";
            this.colten.MinimumWidth = 100;
            this.colten.Name = "colten";
            this.colten.ReadOnly = true;
            // 
            // colemail
            // 
            this.colemail.DataPropertyName = "colemail";
            this.colemail.FillWeight = 150F;
            this.colemail.HeaderText = "Email";
            this.colemail.MinimumWidth = 150;
            this.colemail.Name = "colemail";
            this.colemail.ReadOnly = true;
            this.colemail.Width = 150;
            // 
            // cb_list
            // 
            this.cb_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_list.FormattingEnabled = true;
            this.cb_list.Location = new System.Drawing.Point(609, 11);
            this.cb_list.Name = "cb_list";
            this.cb_list.Size = new System.Drawing.Size(156, 21);
            this.cb_list.TabIndex = 11;
            this.cb_list.SelectedIndexChanged += new System.EventHandler(this.Cb_list_SelectedIndexChanged);
            // 
            // txt_tg_p
            // 
            this.txt_tg_p.Location = new System.Drawing.Point(70, 130);
            this.txt_tg_p.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txt_tg_p.Name = "txt_tg_p";
            this.txt_tg_p.Size = new System.Drawing.Size(35, 20);
            this.txt_tg_p.TabIndex = 6;
            this.txt_tg_p.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(3, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Thời gian\r\n(Phút/giây)";
            // 
            // but_stop
            // 
            this.but_stop.BackColor = System.Drawing.Color.Transparent;
            this.but_stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_stop.Enabled = false;
            this.but_stop.Location = new System.Drawing.Point(70, 153);
            this.but_stop.Name = "but_stop";
            this.but_stop.Size = new System.Drawing.Size(78, 24);
            this.but_stop.TabIndex = 9;
            this.but_stop.Text = "Dừng";
            this.but_stop.UseVisualStyleBackColor = false;
            this.but_stop.Click += new System.EventHandler(this.But_stop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Chào bạn đã đến với SMTP SHERWIN!\r\n";
            this.notifyIcon1.BalloonTipTitle = "SMTP SHERWIN";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Chương trình đang chạy ẩn.";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // txt_tg_s
            // 
            this.txt_tg_s.Location = new System.Drawing.Point(112, 130);
            this.txt_tg_s.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txt_tg_s.Name = "txt_tg_s";
            this.txt_tg_s.Size = new System.Drawing.Size(36, 20);
            this.txt_tg_s.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(102, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "/";
            // 
            // lab_so_lan_gui
            // 
            this.lab_so_lan_gui.AutoSize = true;
            this.lab_so_lan_gui.BackColor = System.Drawing.Color.Transparent;
            this.lab_so_lan_gui.Location = new System.Drawing.Point(148, 132);
            this.lab_so_lan_gui.Name = "lab_so_lan_gui";
            this.lab_so_lan_gui.Size = new System.Drawing.Size(67, 13);
            this.lab_so_lan_gui.TabIndex = 25;
            this.lab_so_lan_gui.Text = "Thực hiện: 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(233, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "/";
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(244, 128);
            this.txt_max.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(43, 20);
            this.txt_max.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(245, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Tên NN";
            // 
            // lab_thanhcong
            // 
            this.lab_thanhcong.AutoSize = true;
            this.lab_thanhcong.BackColor = System.Drawing.Color.Transparent;
            this.lab_thanhcong.Location = new System.Drawing.Point(148, 149);
            this.lab_thanhcong.Name = "lab_thanhcong";
            this.lab_thanhcong.Size = new System.Drawing.Size(77, 13);
            this.lab_thanhcong.TabIndex = 26;
            this.lab_thanhcong.Text = "Thành công: 0";
            // 
            // lab_thatbai
            // 
            this.lab_thatbai.AutoSize = true;
            this.lab_thatbai.BackColor = System.Drawing.Color.Transparent;
            this.lab_thatbai.Location = new System.Drawing.Point(148, 166);
            this.lab_thatbai.Name = "lab_thatbai";
            this.lab_thatbai.Size = new System.Drawing.Size(58, 13);
            this.lab_thatbai.TabIndex = 27;
            this.lab_thatbai.Text = "Thất bại: 0";
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(245, 10);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(42, 21);
            this.cb_port.TabIndex = 1;
            // 
            // chk_ssl
            // 
            this.chk_ssl.AutoSize = true;
            this.chk_ssl.BackColor = System.Drawing.Color.Transparent;
            this.chk_ssl.Checked = true;
            this.chk_ssl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ssl.Location = new System.Drawing.Point(216, 105);
            this.chk_ssl.Name = "chk_ssl";
            this.chk_ssl.Size = new System.Drawing.Size(71, 17);
            this.chk_ssl.TabIndex = 16;
            this.chk_ssl.Text = "TLS/SSL";
            this.chk_ssl.UseVisualStyleBackColor = false;
            // 
            // gv_email
            // 
            this.gv_email.AllowUserToAddRows = false;
            this.gv_email.AllowUserToResizeRows = false;
            this.gv_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_email.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstatus2,
            this.colemail2,
            this.colpass});
            this.gv_email.Location = new System.Drawing.Point(293, 40);
            this.gv_email.MultiSelect = false;
            this.gv_email.Name = "gv_email";
            this.gv_email.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_email.Size = new System.Drawing.Size(173, 147);
            this.gv_email.TabIndex = 30;
            this.gv_email.SelectionChanged += new System.EventHandler(this.Gv_email_SelectionChanged);
            // 
            // colstatus2
            // 
            this.colstatus2.DataPropertyName = "colstatus";
            this.colstatus2.FillWeight = 30F;
            this.colstatus2.HeaderText = "TT";
            this.colstatus2.Name = "colstatus2";
            this.colstatus2.ReadOnly = true;
            this.colstatus2.Width = 30;
            // 
            // colemail2
            // 
            this.colemail2.DataPropertyName = "colemail2";
            this.colemail2.FillWeight = 150F;
            this.colemail2.HeaderText = "Email";
            this.colemail2.MinimumWidth = 150;
            this.colemail2.Name = "colemail2";
            this.colemail2.ReadOnly = true;
            this.colemail2.Width = 150;
            // 
            // colpass
            // 
            this.colpass.DataPropertyName = "colpass";
            this.colpass.HeaderText = "Pass";
            this.colpass.MinimumWidth = 100;
            this.colpass.Name = "colpass";
            this.colpass.ReadOnly = true;
            this.colpass.Visible = false;
            // 
            // but_lay_email
            // 
            this.but_lay_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_lay_email.Location = new System.Drawing.Point(293, 13);
            this.but_lay_email.Name = "but_lay_email";
            this.but_lay_email.Size = new System.Drawing.Size(61, 23);
            this.but_lay_email.TabIndex = 10;
            this.but_lay_email.Text = "Lấy Email";
            this.but_lay_email.UseVisualStyleBackColor = true;
            this.but_lay_email.Click += new System.EventHandler(this.But_lay_email_Click);
            // 
            // cb_email
            // 
            this.cb_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_email.FormattingEnabled = true;
            this.cb_email.Location = new System.Drawing.Point(360, 13);
            this.cb_email.Name = "cb_email";
            this.cb_email.Size = new System.Drawing.Size(106, 21);
            this.cb_email.TabIndex = 11;
            this.cb_email.SelectedIndexChanged += new System.EventHandler(this.Cb_email_SelectedIndexChanged);
            // 
            // chk_radom_email
            // 
            this.chk_radom_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_radom_email.AutoSize = true;
            this.chk_radom_email.BackColor = System.Drawing.Color.Transparent;
            this.chk_radom_email.Location = new System.Drawing.Point(229, 412);
            this.chk_radom_email.Name = "chk_radom_email";
            this.chk_radom_email.Size = new System.Drawing.Size(112, 17);
            this.chk_radom_email.TabIndex = 16;
            this.chk_radom_email.Text = "Thay đổi email gửi";
            this.chk_radom_email.UseVisualStyleBackColor = false;
            // 
            // pgb_main
            // 
            this.pgb_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgb_main.Location = new System.Drawing.Point(599, 405);
            this.pgb_main.Name = "pgb_main";
            this.pgb_main.Size = new System.Drawing.Size(171, 23);
            this.pgb_main.TabIndex = 34;
            // 
            // frm_smtpsherwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(775, 436);
            this.Controls.Add(this.pgb_main);
            this.Controls.Add(this.cb_port);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lab_thatbai);
            this.Controls.Add(this.lab_thanhcong);
            this.Controls.Add(this.lab_so_lan_gui);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_tg_s);
            this.Controls.Add(this.txt_tg_p);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.but_stop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_email);
            this.Controls.Add(this.cb_list);
            this.Controls.Add(this.gv_email);
            this.Controls.Add(this.gv_list);
            this.Controls.Add(this.but_lay_email);
            this.Controls.Add(this.but_lay_ds);
            this.Controls.Add(this.chk_ssl);
            this.Controls.Add(this.chk_radom_email);
            this.Controls.Add(this.chk_guitd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ten_nguoi_nhan);
            this.Controls.Add(this.txt_email_nguoi_nhan);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_ten_hien_thi);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.but_dang_nhap);
            this.Controls.Add(this.but_gui);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(791, 461);
            this.Name = "frm_smtpsherwin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SMTP SHERWIN";
            this.Resize += new System.EventHandler(this.Frm_smtpsherwin_Resize);
            this.groupBox1.ResumeLayout(false);
            this.htmledit.ResumeLayout(false);
            this.htmledit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tg_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tg_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button but_dang_nhap;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Button but_gui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email_nguoi_nhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ten_nguoi_nhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private SpiceLogic.WinHTMLEditor.WinForm.WinFormHtmlEditor htmledit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ten_hien_thi;
        private System.Windows.Forms.CheckBox chk_guitd;
        private System.Windows.Forms.Button but_lay_ds;
        private System.Windows.Forms.DataGridView gv_list;
        private System.Windows.Forms.ComboBox cb_list;
        private System.Windows.Forms.NumericUpDown txt_tg_p;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button but_stop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown txt_tg_s;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lab_so_lan_gui;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown txt_max;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lab_thanhcong;
        private System.Windows.Forms.Label lab_thatbai;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail;
        private System.Windows.Forms.CheckBox chk_ssl;
        private System.Windows.Forms.DataGridView gv_email;
        private System.Windows.Forms.Button but_lay_email;
        private System.Windows.Forms.ComboBox cb_email;
        private System.Windows.Forms.CheckBox chk_radom_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstatus2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpass;
        private System.Windows.Forms.ProgressBar pgb_main;
    }
}

