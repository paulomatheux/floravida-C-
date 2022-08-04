
namespace floravida
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.painel = new Guna.UI2.WinForms.Guna2Panel();
			this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
			this.logintext = new Guna.UI2.WinForms.Guna2TextBox();
			this.labeluser = new System.Windows.Forms.Label();
			this.passtext = new Guna.UI2.WinForms.Guna2TextBox();
			this.labelpass = new System.Windows.Forms.Label();
			this.painel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.painel.SuspendLayout();
			this.painel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// painel
			// 
			this.painel.BackColor = System.Drawing.Color.Transparent;
			this.painel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painel.BackgroundImage")));
			this.painel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.painel.Controls.Add(this.logintext);
			this.painel.Controls.Add(this.labeluser);
			this.painel.Controls.Add(this.passtext);
			this.painel.Controls.Add(this.labelpass);
			this.painel.Controls.Add(this.painel2);
			this.painel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.painel.Location = new System.Drawing.Point(0, 0);
			this.painel.Margin = new System.Windows.Forms.Padding(4);
			this.painel.Name = "painel";
			this.painel.ShadowDecoration.Parent = this.painel;
			this.painel.Size = new System.Drawing.Size(812, 493);
			this.painel.TabIndex = 8;
			// 
			// btnlogin
			// 
			this.btnlogin.Animated = true;
			this.btnlogin.AnimatedGIF = true;
			this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.btnlogin.BorderRadius = 10;
			this.btnlogin.CheckedState.Parent = this.btnlogin;
			this.btnlogin.CustomImages.Parent = this.btnlogin;
			this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnlogin.DisabledState.Parent = this.btnlogin;
			this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
			this.btnlogin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(190)))), ((int)(((byte)(90)))));
			this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogin.ForeColor = System.Drawing.Color.White;
			this.btnlogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(190)))), ((int)(((byte)(90)))));
			this.btnlogin.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnlogin.HoverState.Parent = this.btnlogin;
			this.btnlogin.Location = new System.Drawing.Point(52, 215);
			this.btnlogin.Margin = new System.Windows.Forms.Padding(0);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
			this.btnlogin.PressedDepth = 100;
			this.btnlogin.ShadowDecoration.BorderRadius = 8;
			this.btnlogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(50)))));
			this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
			this.btnlogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 0, 4, 6);
			this.btnlogin.Size = new System.Drawing.Size(238, 40);
			this.btnlogin.TabIndex = 12;
			this.btnlogin.Text = "LOGIN";
			this.btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
			// 
			// logintext
			// 
			this.logintext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.logintext.BorderRadius = 10;
			this.logintext.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.logintext.DefaultText = "";
			this.logintext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.logintext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.logintext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.logintext.DisabledState.Parent = this.logintext;
			this.logintext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.logintext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.logintext.FocusedState.Parent = this.logintext;
			this.logintext.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logintext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.logintext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.logintext.HoverState.Parent = this.logintext;
			this.logintext.IconLeft = ((System.Drawing.Image)(resources.GetObject("logintext.IconLeft")));
			this.logintext.Location = new System.Drawing.Point(292, 151);
			this.logintext.Margin = new System.Windows.Forms.Padding(0);
			this.logintext.Name = "logintext";
			this.logintext.PasswordChar = '\0';
			this.logintext.PlaceholderText = "";
			this.logintext.SelectedText = "";
			this.logintext.ShadowDecoration.Parent = this.logintext;
			this.logintext.Size = new System.Drawing.Size(270, 36);
			this.logintext.TabIndex = 10;
			// 
			// labeluser
			// 
			this.labeluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.labeluser.Font = new System.Drawing.Font("Rokkitt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeluser.ForeColor = System.Drawing.Color.White;
			this.labeluser.Location = new System.Drawing.Point(303, 119);
			this.labeluser.Margin = new System.Windows.Forms.Padding(0);
			this.labeluser.Name = "labeluser";
			this.labeluser.Size = new System.Drawing.Size(100, 30);
			this.labeluser.TabIndex = 8;
			this.labeluser.Text = "Usuário";
			this.labeluser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// passtext
			// 
			this.passtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.passtext.BorderRadius = 10;
			this.passtext.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.passtext.DefaultText = "";
			this.passtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.passtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.passtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passtext.DisabledState.Parent = this.passtext;
			this.passtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.passtext.FocusedState.Parent = this.passtext;
			this.passtext.Font = new System.Drawing.Font("Open Sans", 12F);
			this.passtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.passtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.passtext.HoverState.Parent = this.passtext;
			this.passtext.IconLeft = ((System.Drawing.Image)(resources.GetObject("passtext.IconLeft")));
			this.passtext.Location = new System.Drawing.Point(292, 220);
			this.passtext.Margin = new System.Windows.Forms.Padding(0);
			this.passtext.Name = "passtext";
			this.passtext.PasswordChar = '*';
			this.passtext.PlaceholderText = "";
			this.passtext.SelectedText = "";
			this.passtext.ShadowDecoration.Parent = this.passtext;
			this.passtext.Size = new System.Drawing.Size(270, 36);
			this.passtext.TabIndex = 11;
			// 
			// labelpass
			// 
			this.labelpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.labelpass.Font = new System.Drawing.Font("Rokkitt", 12F, System.Drawing.FontStyle.Bold);
			this.labelpass.ForeColor = System.Drawing.Color.White;
			this.labelpass.Location = new System.Drawing.Point(303, 189);
			this.labelpass.Margin = new System.Windows.Forms.Padding(0);
			this.labelpass.Name = "labelpass";
			this.labelpass.Size = new System.Drawing.Size(100, 30);
			this.labelpass.TabIndex = 9;
			this.labelpass.Text = "Senha";
			this.labelpass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// painel2
			// 
			this.painel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.painel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(200)))), ((int)(((byte)(130)))));
			this.painel2.BorderRadius = 70;
			this.painel2.BorderThickness = 2;
			this.painel2.Controls.Add(this.btnlogin);
			this.painel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.painel2.CustomizableEdges.BottomLeft = false;
			this.painel2.CustomizableEdges.TopRight = false;
			this.painel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
			this.painel2.Location = new System.Drawing.Point(256, 54);
			this.painel2.Name = "painel2";
			this.painel2.ShadowDecoration.BorderRadius = 10;
			this.painel2.ShadowDecoration.Color = System.Drawing.Color.Maroon;
			this.painel2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.painel2.ShadowDecoration.Parent = this.painel2;
			this.painel2.Size = new System.Drawing.Size(330, 340);
			this.painel2.TabIndex = 13;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(812, 493);
			this.Controls.Add(this.painel);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.painel.ResumeLayout(false);
			this.painel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel painel;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Guna.UI2.WinForms.Guna2TextBox passtext;
        private Guna.UI2.WinForms.Guna2TextBox logintext;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labeluser;
		private Guna.UI2.WinForms.Guna2Panel painel2;
	}
}

