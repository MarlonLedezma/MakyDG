namespace MakyDG.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pbBackLogo = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnCerrar = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new MakyDG.Controles.CustomButton();
            this.txtPassWord = new MakyDG.Controles.CustomTextBox();
            this.txtUserName = new MakyDG.Controles.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackLogo
            // 
            this.pbBackLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBackLogo.BackgroundImage")));
            this.pbBackLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBackLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbBackLogo.Image")));
            this.pbBackLogo.Location = new System.Drawing.Point(0, 0);
            this.pbBackLogo.Name = "pbBackLogo";
            this.pbBackLogo.Size = new System.Drawing.Size(397, 133);
            this.pbBackLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackLogo.TabIndex = 1;
            this.pbBackLogo.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(162, 30);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(75, 73);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(0, 133);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(397, 33);
            this.lblTitulo1.TabIndex = 3;
            this.lblTitulo1.Text = "MakyDG";
            this.lblTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Planifica y gestiona con Gantt.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "PassWord";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "login.png");
            this.imageList.Images.SetKeyName(1, "password.png");
            this.imageList.Images.SetKeyName(2, "user.png");
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(0, 439);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(397, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = true;
            this.btnCerrar.Text = "Cerrar Aplicacion";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCerrar_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogin.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.ImageIndex = 0;
            this.btnLogin.ImageList = this.imageList;
            this.btnLogin.Location = new System.Drawing.Point(125, 386);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassWord.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassWord.BorderColor = System.Drawing.Color.Black;
            this.txtPassWord.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtPassWord.BorderRadius = 15;
            this.txtPassWord.BorderSize = 2;
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassWord.Location = new System.Drawing.Point(90, 325);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassWord.Multiline = false;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassWord.PasswordChar = true;
            this.txtPassWord.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassWord.PlaceholderText = "Ingrese la Contraseña";
            this.txtPassWord.Size = new System.Drawing.Size(239, 31);
            this.txtPassWord.TabIndex = 6;
            this.txtPassWord.Texts = "";
            this.txtPassWord.UnderlinedStyle = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderColor = System.Drawing.Color.Black;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.Orange;
            this.txtUserName.BorderRadius = 15;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(90, 240);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "Ingrese el Usuario";
            this.txtUserName.Size = new System.Drawing.Size(239, 31);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 471);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBackLogo);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbBackLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.CustomTextBox txtUserName;
        private System.Windows.Forms.PictureBox pbBackLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controles.CustomTextBox txtPassWord;
        private Controles.CustomButton btnLogin;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.LinkLabel btnCerrar;
    }
}