namespace WindowsFormsApp1
{
    partial class PhoneBook_Title
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneBook_Title));
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newUserBttn = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.Label();
            this.logInBttn = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.uName = new System.Windows.Forms.TextBox();
            this.kulAd = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.numLabel = new System.Windows.Forms.Label();
            this.lnamLabel = new System.Windows.Forms.Label();
            this.namLabel = new System.Windows.Forms.Label();
            this.number_textbox = new System.Windows.Forms.TextBox();
            this.lastN_texbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.add_bttn = new System.Windows.Forms.Button();
            this.USER = new System.Windows.Forms.Label();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.edit_panel = new System.Windows.Forms.Panel();
            this.edit_bttn = new System.Windows.Forms.Button();
            this.selected_panel = new System.Windows.Forms.TableLayoutPanel();
            this.selected_name = new System.Windows.Forms.TextBox();
            this.selected_lastN = new System.Windows.Forms.TextBox();
            this.selected_number = new System.Windows.Forms.TextBox();
            this.logoutbttn = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.language_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.english_menu_bttn = new System.Windows.Forms.ToolStripMenuItem();
            this.turkish_menu_bttn = new System.Windows.Forms.ToolStripMenuItem();
            this.about_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kodABilişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.book = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.programBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.bookPanel.SuspendLayout();
            this.edit_panel.SuspendLayout();
            this.selected_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // newUserBttn
            // 
            this.newUserBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserBttn.Image = ((System.Drawing.Image)(resources.GetObject("newUserBttn.Image")));
            this.newUserBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newUserBttn.Location = new System.Drawing.Point(27, 132);
            this.newUserBttn.Name = "newUserBttn";
            this.newUserBttn.Size = new System.Drawing.Size(188, 42);
            this.newUserBttn.TabIndex = 5;
            this.newUserBttn.Text = "New User";
            this.newUserBttn.UseVisualStyleBackColor = true;
            this.newUserBttn.Click += new System.EventHandler(this.newUserBttn_Click);
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.PaleGreen;
            this.sifre.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.ForeColor = System.Drawing.Color.DarkGreen;
            this.sifre.Location = new System.Drawing.Point(30, 89);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(138, 35);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "Password :";
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.BackColor = System.Drawing.Color.LightGreen;
            this.feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feedback.Location = new System.Drawing.Point(32, 180);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(58, 20);
            this.feedback.TabIndex = 0;
            this.feedback.Text = "Wrong";
            this.feedback.Visible = false;
            this.feedback.Click += new System.EventHandler(this.feedback_Click);
            // 
            // logInBttn
            // 
            this.logInBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logInBttn.Image = ((System.Drawing.Image)(resources.GetObject("logInBttn.Image")));
            this.logInBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logInBttn.Location = new System.Drawing.Point(221, 132);
            this.logInBttn.Name = "logInBttn";
            this.logInBttn.Size = new System.Drawing.Size(180, 42);
            this.logInBttn.TabIndex = 4;
            this.logInBttn.Text = "Login";
            this.logInBttn.UseVisualStyleBackColor = true;
            this.logInBttn.Click += new System.EventHandler(this.logInBttn_Click);
            this.logInBttn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.logInBttn_KeyDown);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(212, 73);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(180, 51);
            this.pass.TabIndex = 3;
            this.pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.logInBttn_KeyDown);
            // 
            // uName
            // 
            this.uName.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uName.Location = new System.Drawing.Point(212, 10);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(180, 51);
            this.uName.TabIndex = 2;
            this.uName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.uName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.logInBttn_KeyDown);
            // 
            // kulAd
            // 
            this.kulAd.AutoSize = true;
            this.kulAd.BackColor = System.Drawing.Color.PaleGreen;
            this.kulAd.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kulAd.ForeColor = System.Drawing.Color.DarkGreen;
            this.kulAd.Location = new System.Drawing.Point(30, 26);
            this.kulAd.Name = "kulAd";
            this.kulAd.Size = new System.Drawing.Size(153, 35);
            this.kulAd.TabIndex = 0;
            this.kulAd.Text = "User Name :";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.sifre);
            this.loginPanel.Controls.Add(this.kulAd);
            this.loginPanel.Controls.Add(this.feedback);
            this.loginPanel.Controls.Add(this.uName);
            this.loginPanel.Controls.Add(this.newUserBttn);
            this.loginPanel.Controls.Add(this.pass);
            this.loginPanel.Controls.Add(this.logInBttn);
            this.loginPanel.Location = new System.Drawing.Point(35, 255);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(432, 216);
            this.loginPanel.TabIndex = 7;
            // 
            // bookPanel
            // 
            this.bookPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))));
            this.bookPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookPanel.Controls.Add(this.numLabel);
            this.bookPanel.Controls.Add(this.lnamLabel);
            this.bookPanel.Controls.Add(this.namLabel);
            this.bookPanel.Controls.Add(this.number_textbox);
            this.bookPanel.Controls.Add(this.lastN_texbox);
            this.bookPanel.Controls.Add(this.name_textbox);
            this.bookPanel.Controls.Add(this.add_bttn);
            this.bookPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bookPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookPanel.Location = new System.Drawing.Point(38, 224);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(426, 268);
            this.bookPanel.TabIndex = 8;
            this.bookPanel.Visible = false;
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numLabel.Location = new System.Drawing.Point(18, 137);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(100, 29);
            this.numLabel.TabIndex = 6;
            this.numLabel.Text = "Number";
            // 
            // lnamLabel
            // 
            this.lnamLabel.AutoSize = true;
            this.lnamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnamLabel.Location = new System.Drawing.Point(18, 89);
            this.lnamLabel.Name = "lnamLabel";
            this.lnamLabel.Size = new System.Drawing.Size(128, 29);
            this.lnamLabel.TabIndex = 5;
            this.lnamLabel.Text = "Last Name";
            // 
            // namLabel
            // 
            this.namLabel.AutoSize = true;
            this.namLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.namLabel.Location = new System.Drawing.Point(18, 41);
            this.namLabel.Name = "namLabel";
            this.namLabel.Size = new System.Drawing.Size(78, 29);
            this.namLabel.TabIndex = 4;
            this.namLabel.Text = "Name";
            this.namLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // number_textbox
            // 
            this.number_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_textbox.Location = new System.Drawing.Point(168, 134);
            this.number_textbox.Name = "number_textbox";
            this.number_textbox.Size = new System.Drawing.Size(229, 34);
            this.number_textbox.TabIndex = 3;
            // 
            // lastN_texbox
            // 
            this.lastN_texbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastN_texbox.Location = new System.Drawing.Point(168, 86);
            this.lastN_texbox.Name = "lastN_texbox";
            this.lastN_texbox.Size = new System.Drawing.Size(229, 34);
            this.lastN_texbox.TabIndex = 2;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_textbox.Location = new System.Drawing.Point(168, 38);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(229, 34);
            this.name_textbox.TabIndex = 1;
            // 
            // add_bttn
            // 
            this.add_bttn.BackColor = System.Drawing.Color.Honeydew;
            this.add_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_bttn.ForeColor = System.Drawing.Color.DarkGreen;
            this.add_bttn.Image = ((System.Drawing.Image)(resources.GetObject("add_bttn.Image")));
            this.add_bttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_bttn.Location = new System.Drawing.Point(156, 207);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(93, 39);
            this.add_bttn.TabIndex = 0;
            this.add_bttn.Text = "Add";
            this.add_bttn.UseVisualStyleBackColor = false;
            this.add_bttn.Click += new System.EventHandler(this.addB_Click);
            // 
            // USER
            // 
            this.USER.AutoSize = true;
            this.USER.Location = new System.Drawing.Point(582, 13);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(0, 17);
            this.USER.TabIndex = 9;
            // 
            // delete_bttn
            // 
            this.delete_bttn.BackColor = System.Drawing.Color.Honeydew;
            this.delete_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_bttn.ForeColor = System.Drawing.Color.DarkGreen;
            this.delete_bttn.Image = ((System.Drawing.Image)(resources.GetObject("delete_bttn.Image")));
            this.delete_bttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_bttn.Location = new System.Drawing.Point(47, 9);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(102, 39);
            this.delete_bttn.TabIndex = 7;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // edit_panel
            // 
            this.edit_panel.BackColor = System.Drawing.Color.Transparent;
            this.edit_panel.Controls.Add(this.edit_bttn);
            this.edit_panel.Controls.Add(this.delete_bttn);
            this.edit_panel.Location = new System.Drawing.Point(614, 546);
            this.edit_panel.Name = "edit_panel";
            this.edit_panel.Size = new System.Drawing.Size(365, 48);
            this.edit_panel.TabIndex = 10;
            this.edit_panel.Visible = false;
            // 
            // edit_bttn
            // 
            this.edit_bttn.BackColor = System.Drawing.Color.Honeydew;
            this.edit_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.edit_bttn.ForeColor = System.Drawing.Color.DarkGreen;
            this.edit_bttn.Image = ((System.Drawing.Image)(resources.GetObject("edit_bttn.Image")));
            this.edit_bttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_bttn.Location = new System.Drawing.Point(230, 9);
            this.edit_bttn.Name = "edit_bttn";
            this.edit_bttn.Size = new System.Drawing.Size(102, 39);
            this.edit_bttn.TabIndex = 8;
            this.edit_bttn.Text = "Edit";
            this.edit_bttn.UseVisualStyleBackColor = false;
            this.edit_bttn.Click += new System.EventHandler(this.edit_bttn_Click);
            // 
            // selected_panel
            // 
            this.selected_panel.ColumnCount = 3;
            this.selected_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selected_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selected_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selected_panel.Controls.Add(this.selected_name, 0, 0);
            this.selected_panel.Controls.Add(this.selected_lastN, 1, 0);
            this.selected_panel.Controls.Add(this.selected_number, 2, 0);
            this.selected_panel.Location = new System.Drawing.Point(517, 522);
            this.selected_panel.Name = "selected_panel";
            this.selected_panel.RowCount = 1;
            this.selected_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selected_panel.Size = new System.Drawing.Size(580, 31);
            this.selected_panel.TabIndex = 12;
            this.selected_panel.Visible = false;
            // 
            // selected_name
            // 
            this.selected_name.Location = new System.Drawing.Point(3, 3);
            this.selected_name.Name = "selected_name";
            this.selected_name.Size = new System.Drawing.Size(187, 22);
            this.selected_name.TabIndex = 14;
            this.selected_name.Text = "(name)";
            // 
            // selected_lastN
            // 
            this.selected_lastN.Location = new System.Drawing.Point(196, 3);
            this.selected_lastN.Name = "selected_lastN";
            this.selected_lastN.Size = new System.Drawing.Size(187, 22);
            this.selected_lastN.TabIndex = 15;
            this.selected_lastN.Text = "(last name)";
            // 
            // selected_number
            // 
            this.selected_number.Location = new System.Drawing.Point(389, 3);
            this.selected_number.Name = "selected_number";
            this.selected_number.Size = new System.Drawing.Size(188, 22);
            this.selected_number.TabIndex = 16;
            this.selected_number.Text = "number";
            // 
            // logoutbttn
            // 
            this.logoutbttn.BackColor = System.Drawing.Color.MistyRose;
            this.logoutbttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutbttn.ForeColor = System.Drawing.Color.Black;
            this.logoutbttn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbttn.Image")));
            this.logoutbttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbttn.Location = new System.Drawing.Point(195, 533);
            this.logoutbttn.Name = "logoutbttn";
            this.logoutbttn.Size = new System.Drawing.Size(87, 39);
            this.logoutbttn.TabIndex = 13;
            this.logoutbttn.Text = "Logout";
            this.logoutbttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutbttn.UseVisualStyleBackColor = false;
            this.logoutbttn.Click += new System.EventHandler(this.logoutbttn_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.language_MenuItem,
            this.about_MenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1120, 28);
            this.menu.TabIndex = 14;
            this.menu.Text = "menuStrip1";
            // 
            // language_MenuItem
            // 
            this.language_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.english_menu_bttn,
            this.turkish_menu_bttn});
            this.language_MenuItem.Name = "language_MenuItem";
            this.language_MenuItem.Size = new System.Drawing.Size(86, 24);
            this.language_MenuItem.Text = "Language";
            // 
            // english_menu_bttn
            // 
            this.english_menu_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.english_menu_bttn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_great_britain_17;
            this.english_menu_bttn.Name = "english_menu_bttn";
            this.english_menu_bttn.Size = new System.Drawing.Size(131, 26);
            this.english_menu_bttn.Text = "English";
            this.english_menu_bttn.Click += new System.EventHandler(this.english_menu_bttn_Click);
            // 
            // turkish_menu_bttn
            // 
            this.turkish_menu_bttn.BackColor = System.Drawing.SystemColors.Control;
            this.turkish_menu_bttn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_turkey_17;
            this.turkish_menu_bttn.Name = "turkish_menu_bttn";
            this.turkish_menu_bttn.Size = new System.Drawing.Size(131, 26);
            this.turkish_menu_bttn.Text = "Türkçe";
            this.turkish_menu_bttn.Click += new System.EventHandler(this.turkish_menu_bttn_Click);
            // 
            // about_MenuItem
            // 
            this.about_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kodABilişimToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.about_MenuItem.Name = "about_MenuItem";
            this.about_MenuItem.Size = new System.Drawing.Size(62, 24);
            this.about_MenuItem.Text = "About";
            // 
            // kodABilişimToolStripMenuItem
            // 
            this.kodABilişimToolStripMenuItem.Name = "kodABilişimToolStripMenuItem";
            this.kodABilişimToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.kodABilişimToolStripMenuItem.Text = "Kod-A Bilişim";
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.developerToolStripMenuItem.Text = "Developer";
            // 
            // book
            // 
            this.book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.book.Location = new System.Drawing.Point(519, 50);
            this.book.Name = "book";
            this.book.RowTemplate.Height = 24;
            this.book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.book.Size = new System.Drawing.Size(574, 442);
            this.book.TabIndex = 15;
            this.book.Visible = false;
            this.book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.book_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Number";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(680, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // programBindingSource2
            // 
            this.programBindingSource2.DataSource = typeof(WindowsFormsApp1.Program);
            // 
            // PhoneBook_Title
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book);
            this.Controls.Add(this.logoutbttn);
            this.Controls.Add(this.selected_panel);
            this.Controls.Add(this.edit_panel);
            this.Controls.Add(this.USER);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.bookPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "PhoneBook_Title";
            this.Text = "PhoneBook";
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            this.edit_panel.ResumeLayout(false);
            this.selected_panel.ResumeLayout(false);
            this.selected_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newUserBttn;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label feedback;
        private System.Windows.Forms.Button logInBttn;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Label kulAd;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Label namLabel;
        private System.Windows.Forms.TextBox number_textbox;
        private System.Windows.Forms.TextBox lastN_texbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button add_bttn;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label lnamLabel;
        private System.Windows.Forms.Label USER;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Panel edit_panel;
        private System.Windows.Forms.Button edit_bttn;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.TableLayoutPanel selected_panel;
        private System.Windows.Forms.Button logoutbttn;
        private System.Windows.Forms.TextBox selected_name;
        private System.Windows.Forms.TextBox selected_lastN;
        private System.Windows.Forms.TextBox selected_number;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem language_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem english_menu_bttn;
        private System.Windows.Forms.ToolStripMenuItem turkish_menu_bttn;
        private System.Windows.Forms.ToolStripMenuItem about_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem kodABilişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.BindingSource programBindingSource2;
        private System.Windows.Forms.DataGridView book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

