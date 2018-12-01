namespace WerewolfClient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.picturelogin = new System.Windows.Forms.PictureBox();
            this.TbGame = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCharacter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.BtnCharacter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbGame);
            this.Controls.Add(this.picturelogin);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picturelogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // picturelogin
            // 
            this.picturelogin.Size = new System.Drawing.Size((int)(this.Width / (this.Width / 320)), (int)(this.Width / (this.Width / 320)));
            this.picturelogin.BackColor = System.Drawing.Color.Transparent;
            this.picturelogin.Image = ((System.Drawing.Image)(resources.GetObject("picturelogin.Image")));
            this.picturelogin.Location = new System.Drawing.Point((int)(this.Width / 2) - (picturelogin.Size.Width / 2), (int)(this.Width * 0.01));
            this.picturelogin.Name = "picturelogin";
            this.picturelogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturelogin.TabIndex = 6;
            this.picturelogin.TabStop = false;
            // 
            // TbGame
            //
            this.TbGame.Size = new System.Drawing.Size((int)(this.Width / (this.Width / 320)), (int)(this.Width / (this.Width / 36)));
            this.TbGame.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TbGame.Font = new System.Drawing.Font("TH Sarabun New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TbGame.ForeColor = System.Drawing.Color.Sienna;
            this.TbGame.FormattingEnabled = true;
            this.TbGame.Items.AddRange(new object[] {
            "2 Player",
            "4 Player",
            "16 Player"});
            this.TbGame.Location = new System.Drawing.Point(picturelogin.Location.X, (int)(picturelogin.Location.Y + picturelogin.Size.Height + 10));
            this.TbGame.Name = "TbGame";
            this.TbGame.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Size = new System.Drawing.Size((int)(this.Width / (this.Width / 62)), (int)(this.Width / (this.Width / 32)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("TH Sarabun New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Text = "Player";
            this.label4.Location = new System.Drawing.Point((int)((this.Width / 2) - (TbGame.Size.Width / 2) - 10 - (int)(label4.Text.Length*10)), (int)(picturelogin.Location.Y + picturelogin.Size.Height + 10));
            this.label4.Name = "label4";
            this.label4.TabIndex = 13;
            // 
            // TbLogin
            //
            this.TbLogin.Size = new System.Drawing.Size(TbGame.Size.Width, (int)(this.Width / (this.Width / 35))); 
            this.TbLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TbLogin.Font = new System.Drawing.Font("TH Sarabun New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLogin.ForeColor = System.Drawing.Color.Sienna;
            this.TbLogin.Location = new System.Drawing.Point(picturelogin.Location.X, (int)(TbGame.Location.Y + TbGame.Size.Height + 10));
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Size = new System.Drawing.Size((int)(this.Width / (this.Width / 97)), label4.Size.Height);
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TH Sarabun New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Text = "User name";
            this.label1.Location = new System.Drawing.Point((int)((this.Width / 2) - (TbGame.Size.Width / 2) - 10 - (int)(label1.Text.Length * 10)), (int)(TbGame.Location.Y + TbGame.Size.Height + 10));
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            // 
            // TbPassword
            //
            this.TbPassword.Size = new System.Drawing.Size(TbGame.Size.Width, TbLogin.Size.Height); 
            this.TbPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TbPassword.Font = new System.Drawing.Font("TH Sarabun New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.ForeColor = System.Drawing.Color.Sienna;
            this.TbPassword.Location = new System.Drawing.Point(picturelogin.Location.X, (int)(TbLogin.Location.Y + TbLogin.Size.Height + 10));
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Size = new System.Drawing.Size((int)(this.Width / (this.Width / 85)), label4.Size.Height);
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH Sarabun New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Text = "Password";
            this.label2.Location = new System.Drawing.Point((int)((this.Width / 2) - (TbGame.Size.Width / 2) - 10 - (int)(label2.Text.Length * 10)), (int)(TbLogin.Location.Y + TbLogin.Size.Height + 10));
            this.label2.Name = "label2"; 
            this.label2.TabIndex = 1;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Size = new System.Drawing.Size((int)(this.Width / (this.Width / 100)), (int)(this.Width / (this.Width / 45)));
            this.BtnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSignIn.BackgroundImage")));
            this.BtnSignIn.Font = new System.Drawing.Font("TH Sarabun New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Location = new System.Drawing.Point((int)((this.Width / 2) - (BtnSignIn.Size.Width / 2)), (int)(TbPassword.Location.Y + TbPassword.Size.Height + 10));
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.TabIndex = 4;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Size = new System.Drawing.Size(BtnSignIn.Size.Width, BtnSignIn.Size.Height);
            this.BtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSignUp.BackgroundImage")));
            this.BtnSignUp.Font = new System.Drawing.Font("TH Sarabun New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.Location = new System.Drawing.Point(picturelogin.Location.X, BtnSignIn.Location.Y);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.TabIndex = 5;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // BtnCharacter
            // 
            this.BtnCharacter.Size = new System.Drawing.Size(BtnSignIn.Size.Width, BtnSignIn.Size.Height);
            this.BtnCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCharacter.BackgroundImage")));
            this.BtnCharacter.Font = new System.Drawing.Font("TH Sarabun New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCharacter.Location = new System.Drawing.Point((int)((this.Width / 2) + (picturelogin.Size.Width / 2) - BtnCharacter.Size.Width), BtnSignIn.Location.Y);
            this.BtnCharacter.Name = "BtnCharacter";
            this.BtnCharacter.TabIndex = 14;
            this.BtnCharacter.Text = "Character";
            this.BtnCharacter.UseVisualStyleBackColor = true;
            this.BtnCharacter.Click += new System.EventHandler(this.BtnHowTo_Click);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.PictureBox picturelogin;
        private System.Windows.Forms.ComboBox TbGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCharacter;
    }
}