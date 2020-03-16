namespace ImagineSponsors
{
    partial class MainForm
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
            this.panel_tobBar = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_saveEmail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.list_attachements = new System.Windows.Forms.ListView();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_title = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_body = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_replace = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_concat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.list_emails = new System.Windows.Forms.ListView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbox_emailList = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbox_mail = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_emailLogged = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_tobBar.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tobBar
            // 
            this.panel_tobBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_tobBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_tobBar.Controls.Add(this.btn_minimize);
            this.panel_tobBar.Controls.Add(this.btn_exit);
            this.panel_tobBar.Controls.Add(this.label2);
            this.panel_tobBar.Location = new System.Drawing.Point(0, 0);
            this.panel_tobBar.Name = "panel_tobBar";
            this.panel_tobBar.Size = new System.Drawing.Size(1177, 29);
            this.panel_tobBar.TabIndex = 5;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.Location = new System.Drawing.Point(1119, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 28);
            this.btn_minimize.TabIndex = 5;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1147, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1177, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SPONSOR STATION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseMove);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Aqua;
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton2);
            this.bunifuCards1.Controls.Add(this.btn_saveEmail);
            this.bunifuCards1.Controls.Add(this.list_attachements);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards1.Controls.Add(this.txt_title);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.txt_body);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 36);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(384, 582);
            this.bunifuCards1.TabIndex = 6;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "+";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(324, 483);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(50, 38);
            this.bunifuFlatButton2.TabIndex = 11;
            this.bunifuFlatButton2.Text = "+";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // btn_saveEmail
            // 
            this.btn_saveEmail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_saveEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_saveEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveEmail.BorderRadius = 0;
            this.btn_saveEmail.ButtonText = "SAVE EMAIL";
            this.btn_saveEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveEmail.DisabledColor = System.Drawing.Color.Gray;
            this.btn_saveEmail.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_saveEmail.Iconimage = null;
            this.btn_saveEmail.Iconimage_right = null;
            this.btn_saveEmail.Iconimage_right_Selected = null;
            this.btn_saveEmail.Iconimage_Selected = null;
            this.btn_saveEmail.IconMarginLeft = 0;
            this.btn_saveEmail.IconMarginRight = 0;
            this.btn_saveEmail.IconRightVisible = true;
            this.btn_saveEmail.IconRightZoom = 0D;
            this.btn_saveEmail.IconVisible = true;
            this.btn_saveEmail.IconZoom = 90D;
            this.btn_saveEmail.IsTab = false;
            this.btn_saveEmail.Location = new System.Drawing.Point(11, 527);
            this.btn_saveEmail.Name = "btn_saveEmail";
            this.btn_saveEmail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_saveEmail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_saveEmail.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_saveEmail.selected = false;
            this.btn_saveEmail.Size = new System.Drawing.Size(363, 39);
            this.btn_saveEmail.TabIndex = 10;
            this.btn_saveEmail.Text = "SAVE EMAIL";
            this.btn_saveEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_saveEmail.Textcolor = System.Drawing.Color.White;
            this.btn_saveEmail.TextFont = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveEmail.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // list_attachements
            // 
            this.list_attachements.HideSelection = false;
            this.list_attachements.Location = new System.Drawing.Point(11, 483);
            this.list_attachements.Name = "list_attachements";
            this.list_attachements.Size = new System.Drawing.Size(307, 38);
            this.list_attachements.TabIndex = 9;
            this.list_attachements.UseCompatibleStateImageBehavior = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(11, 445);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(185, 34);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "ATTACHEMENTS";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_title
            // 
            this.txt_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_title.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_title.HintForeColor = System.Drawing.Color.Aqua;
            this.txt_title.HintText = "";
            this.txt_title.isPassword = false;
            this.txt_title.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_title.LineIdleColor = System.Drawing.Color.Aqua;
            this.txt_title.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_title.LineThickness = 3;
            this.txt_title.Location = new System.Drawing.Point(87, 69);
            this.txt_title.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(287, 33);
            this.txt_title.TabIndex = 7;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(8, 68);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(366, 34);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "TITLE";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(11, 113);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(363, 34);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "BODY";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_body
            // 
            this.txt_body.AutoCompleteCustomSource.AddRange(new string[] {
            "xdddd"});
            this.txt_body.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txt_body.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_body.BorderColor = System.Drawing.Color.Aqua;
            this.txt_body.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_body.Location = new System.Drawing.Point(11, 150);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(363, 281);
            this.txt_body.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(378, 34);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "MAIL";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuCards2.Controls.Add(this.btn_replace);
            this.bunifuCards2.Controls.Add(this.btn_save);
            this.bunifuCards2.Controls.Add(this.btn_concat);
            this.bunifuCards2.Controls.Add(this.btn_clear);
            this.bunifuCards2.Controls.Add(this.list_emails);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(393, 36);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(384, 582);
            this.bunifuCards2.TabIndex = 7;
            // 
            // btn_replace
            // 
            this.btn_replace.Activecolor = System.Drawing.Color.Teal;
            this.btn_replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_replace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_replace.BorderRadius = 0;
            this.btn_replace.ButtonText = "REPLACE";
            this.btn_replace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_replace.DisabledColor = System.Drawing.Color.Gray;
            this.btn_replace.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_replace.Iconimage = null;
            this.btn_replace.Iconimage_right = null;
            this.btn_replace.Iconimage_right_Selected = null;
            this.btn_replace.Iconimage_Selected = null;
            this.btn_replace.IconMarginLeft = 0;
            this.btn_replace.IconMarginRight = 0;
            this.btn_replace.IconRightVisible = true;
            this.btn_replace.IconRightZoom = 0D;
            this.btn_replace.IconVisible = true;
            this.btn_replace.IconZoom = 90D;
            this.btn_replace.IsTab = false;
            this.btn_replace.Location = new System.Drawing.Point(9, 527);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_replace.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_replace.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_replace.selected = false;
            this.btn_replace.Size = new System.Drawing.Size(168, 39);
            this.btn_replace.TabIndex = 14;
            this.btn_replace.Text = "REPLACE";
            this.btn_replace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_replace.Textcolor = System.Drawing.Color.White;
            this.btn_replace.TextFont = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replace.Click += new System.EventHandler(this.BunifuFlatButton4_Click);
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "SAVE";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = null;
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 0;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 90D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(183, 527);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.Lime;
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(189, 39);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "SAVE";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_concat
            // 
            this.btn_concat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_concat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_concat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_concat.BorderRadius = 0;
            this.btn_concat.ButtonText = "CONCATENATE";
            this.btn_concat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_concat.DisabledColor = System.Drawing.Color.Gray;
            this.btn_concat.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_concat.Iconimage = null;
            this.btn_concat.Iconimage_right = null;
            this.btn_concat.Iconimage_right_Selected = null;
            this.btn_concat.Iconimage_Selected = null;
            this.btn_concat.IconMarginLeft = 0;
            this.btn_concat.IconMarginRight = 0;
            this.btn_concat.IconRightVisible = true;
            this.btn_concat.IconRightZoom = 0D;
            this.btn_concat.IconVisible = true;
            this.btn_concat.IconZoom = 90D;
            this.btn_concat.IsTab = false;
            this.btn_concat.Location = new System.Drawing.Point(183, 482);
            this.btn_concat.Name = "btn_concat";
            this.btn_concat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_concat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_concat.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_concat.selected = false;
            this.btn_concat.Size = new System.Drawing.Size(189, 39);
            this.btn_concat.TabIndex = 12;
            this.btn_concat.Text = "CONCATENATE";
            this.btn_concat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_concat.Textcolor = System.Drawing.Color.White;
            this.btn_concat.TextFont = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concat.Click += new System.EventHandler(this.BunifuFlatButton1_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Activecolor = System.Drawing.Color.Maroon;
            this.btn_clear.BackColor = System.Drawing.Color.Maroon;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.BorderRadius = 0;
            this.btn_clear.ButtonText = "CLEAR";
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clear.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clear.Iconimage = null;
            this.btn_clear.Iconimage_right = null;
            this.btn_clear.Iconimage_right_Selected = null;
            this.btn_clear.Iconimage_Selected = null;
            this.btn_clear.IconMarginLeft = 0;
            this.btn_clear.IconMarginRight = 0;
            this.btn_clear.IconRightVisible = true;
            this.btn_clear.IconRightZoom = 0D;
            this.btn_clear.IconVisible = true;
            this.btn_clear.IconZoom = 90D;
            this.btn_clear.IsTab = false;
            this.btn_clear.Location = new System.Drawing.Point(9, 482);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Normalcolor = System.Drawing.Color.Maroon;
            this.btn_clear.OnHovercolor = System.Drawing.Color.Red;
            this.btn_clear.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clear.selected = false;
            this.btn_clear.Size = new System.Drawing.Size(168, 39);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.Textcolor = System.Drawing.Color.White;
            this.btn_clear.TextFont = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // list_emails
            // 
            this.list_emails.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_emails.HideSelection = false;
            this.list_emails.LabelWrap = false;
            this.list_emails.Location = new System.Drawing.Point(8, 47);
            this.list_emails.Name = "list_emails";
            this.list_emails.Size = new System.Drawing.Size(364, 429);
            this.list_emails.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_emails.TabIndex = 10;
            this.list_emails.UseCompatibleStateImageBehavior = false;
            this.list_emails.View = System.Windows.Forms.View.List;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(378, 34);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "RECIPIENTS";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuCards3.Controls.Add(this.btn_send);
            this.bunifuCards3.Controls.Add(this.cbox_emailList);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards3.Controls.Add(this.cbox_mail);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(783, 36);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(384, 582);
            this.bunifuCards3.TabIndex = 8;
            // 
            // btn_send
            // 
            this.btn_send.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_send.BackColor = System.Drawing.Color.Lime;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send.BorderRadius = 0;
            this.btn_send.ButtonText = "SEND";
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.DisabledColor = System.Drawing.Color.Gray;
            this.btn_send.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_send.Iconimage = null;
            this.btn_send.Iconimage_right = null;
            this.btn_send.Iconimage_right_Selected = null;
            this.btn_send.Iconimage_Selected = null;
            this.btn_send.IconMarginLeft = 0;
            this.btn_send.IconMarginRight = 0;
            this.btn_send.IconRightVisible = true;
            this.btn_send.IconRightZoom = 0D;
            this.btn_send.IconVisible = true;
            this.btn_send.IconZoom = 90D;
            this.btn_send.IsTab = false;
            this.btn_send.Location = new System.Drawing.Point(18, 516);
            this.btn_send.Name = "btn_send";
            this.btn_send.Normalcolor = System.Drawing.Color.Lime;
            this.btn_send.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_send.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_send.selected = false;
            this.btn_send.Size = new System.Drawing.Size(348, 50);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "SEND";
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_send.Textcolor = System.Drawing.Color.White;
            this.btn_send.TextFont = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // cbox_emailList
            // 
            this.cbox_emailList.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_emailList.FormattingEnabled = true;
            this.cbox_emailList.Location = new System.Drawing.Point(18, 106);
            this.cbox_emailList.Name = "cbox_emailList";
            this.cbox_emailList.Size = new System.Drawing.Size(348, 28);
            this.cbox_emailList.TabIndex = 8;
            this.cbox_emailList.SelectedIndexChanged += new System.EventHandler(this.Cbox_emailList_SelectedIndexChanged);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(18, 144);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(348, 34);
            this.bunifuCustomLabel8.TabIndex = 7;
            this.bunifuCustomLabel8.Text = "Mail";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbox_mail
            // 
            this.cbox_mail.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_mail.FormattingEnabled = true;
            this.cbox_mail.Location = new System.Drawing.Point(18, 181);
            this.cbox_mail.Name = "cbox_mail";
            this.cbox_mail.Size = new System.Drawing.Size(348, 28);
            this.cbox_mail.TabIndex = 6;
            this.cbox_mail.SelectedIndexChanged += new System.EventHandler(this.Cbox_mail_SelectedIndexChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCustomLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(18, 69);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(348, 34);
            this.bunifuCustomLabel7.TabIndex = 5;
            this.bunifuCustomLabel7.Text = "Email list";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 10);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(381, 34);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "SETTINGS AND SENDER";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_emailLogged
            // 
            this.lbl_emailLogged.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailLogged.ForeColor = System.Drawing.Color.Blue;
            this.lbl_emailLogged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_emailLogged.Location = new System.Drawing.Point(8, 622);
            this.lbl_emailLogged.Name = "lbl_emailLogged";
            this.lbl_emailLogged.Size = new System.Drawing.Size(369, 22);
            this.lbl_emailLogged.TabIndex = 9;
            this.lbl_emailLogged.Text = "Logged in as : ";
            this.lbl_emailLogged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Lime;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "LOG OUT";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(1045, 621);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Lime;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(122, 23);
            this.bunifuFlatButton3.TabIndex = 15;
            this.bunifuFlatButton3.Text = "LOG OUT";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BunifuFlatButton3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 652);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.lbl_emailLogged);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel_tobBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_tobBar.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_tobBar;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_body;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ListView list_attachements;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_title;
        private Bunifu.Framework.UI.BunifuFlatButton btn_saveEmail;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_replace;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private Bunifu.Framework.UI.BunifuFlatButton btn_concat;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clear;
        private System.Windows.Forms.ListView list_emails;
        private Bunifu.Framework.UI.BunifuFlatButton btn_send;
        private System.Windows.Forms.ComboBox cbox_emailList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox cbox_mail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_emailLogged;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}

